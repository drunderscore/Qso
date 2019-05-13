using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Qso;
using Qso.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QsoClient
{
    public partial class MainWindow : Form
    {
        public PlayerLoot[] uiLoot;
        public LootRecipe[] uiRecipes;

        public MainWindow()
        {
            InitializeComponent();
            QsoApi.EndpointEvent += OnEndpointEvent;
        }

        private void OnEndpointEvent( object src, EndpointEventArgs args )
        {
            if ( args.EventType == "Update" && args.URI == "/lol-gameflow/v1/session" )
            {
                var phase = args.JSON["phase"].Value<string>();

                if ( phase == "EndOfGame" && downloadAllReplaysCheckbox.Checked )
                {
                    var gameId = args.JSON["gameData"]["gameId"].Value<long>();
                    try
                    {
                        QsoApi.DownloadReplay( gameId );
                        Console.WriteLine( $"Downloading replay for game {gameId}" );
                        trayIcon.ShowBalloonTip( 2500, "Qso Client", "Downloading replay of your latest game!", ToolTipIcon.Info );
                        if ( alertWhenManyReplaysCheckbox.Checked )
                        {
                            DirectoryInfo d = new DirectoryInfo( QsoApi.GetReplaysPath() );
                            if ( d.GetFiles().Length >= 50 )
                            {
                                long size = 0;
                                d.GetFiles().Select( f => f.Length ).ToList().ForEach( s => size += s );
                                MessageBox.Show( $"Your replay folder currently contains {d.GetFiles().Length} files, sitting at {size / 1048576}MB. You should clean it out to save space on your drive.", "Replay Folder Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                            }
                        }
                    }
                    catch ( QsoEndpointException )
                    {
                        trayIcon.ShowBalloonTip( 2500, "Qso Client", "Failed to download latest replay.", ToolTipIcon.Error );
                    }
                }
                else if ( phase == "ReadyCheck" && autoAcceptQueueCheckbox.Checked )
                    QsoApi.AcceptQueue();
            }
        }

        private void MainWindow_Load( object sender, EventArgs e )
        {
            uiLoot = QsoApi.GetMyPlayerLoot();
            allLootCombo.DataSource = uiLoot;
            recipesCombo.DataSource = uiRecipes;
            RuneManager.Populate();
            Console.WriteLine( string.Join( ",", RuneManager.Pages.Select( p => p.Name ) ) );
        }

        private void MainWindow_Resize( object sender, EventArgs e )
        {
            if ( WindowState == FormWindowState.Minimized )
                Hide();
        }

        private void trayIcon_MouseDoubleClick( object sender, MouseEventArgs e )
        {
            if ( !Visible )
            {
                Show();
                WindowState = FormWindowState.Normal;
                Activate();
            }
        }

        private void allLootCombo_SelectedIndexChanged( object sender, EventArgs e )
        {
            SetLootInput( false );
            var target = uiLoot[allLootCombo.SelectedIndex];
            try
            {
                uiRecipes = target.GetRecipes();
            }
            catch ( QsoEndpointException )
            {
                MessageBox.Show( "Unable to update recipes for that item.", "Errror", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            recipesCombo.DataSource = uiRecipes;
            SetLootInput( true );
        }

        private void updateLootBtn_Click( object sender, EventArgs e )
        {
            SetLootInput( false );
            uiLoot = QsoApi.GetMyPlayerLoot();
            allLootCombo.DataSource = uiLoot;
            SetLootInput( true );
        }

        private void SetLootInput( bool v )
        {
            allLootCombo.Enabled = v;
            recipesCombo.Enabled = v;
        }

        private void CraftRecipeUI( bool many )
        {
            if ( uiRecipes == null || uiLoot == null )
            {
                MessageBox.Show( "You must select an item and a recipe first.", "", MessageBoxButtons.OK, MessageBoxIcon.Information );
                return;
            }
            try
            {
                var item = uiLoot[allLootCombo.SelectedIndex];
                var recipe = uiRecipes[recipesCombo.SelectedIndex];
                var repeat = many ? 10 : 0;
                var update = QsoApi.CraftRecipe( item, recipe, repeat );
            }
            catch ( QsoEndpointException ex )
            {
                MessageBox.Show( $"Unable to craft {uiLoot[allLootCombo.SelectedIndex]}: {ex.ErrorResponse.Message}" );
            }
        }

        private void craftBtn_Click( object sender, EventArgs e )
        {
            CraftRecipeUI( false );
        }

        private void craftManyBtn_Click( object sender, EventArgs e )
        {
            CraftRecipeUI( true );
        }

        private void disenchantAllBtn_Click( object sender, EventArgs e )
        {
            if ( MessageBox.Show( "Are you sure you wish to continue? All this loot will be lost forever! (a long time!)", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation ) == DialogResult.No )
                return;
            var be = 0;
            var oe = 0;
            foreach ( var loot in uiLoot )
            {
                if ( loot.Type == "CHAMPION_RENTAL" && disenChampionsCheckbox.Checked )
                {
                    be += loot.DisenchantValue;
                    try
                    {
                        QsoApi.CraftRecipe( loot.Name, "CHAMPION_RENTAL_disenchant" );
                    }
                    catch ( QsoEndpointException )
                    {
                        if ( MessageBox.Show( $"Failed disenchanting loot item {loot.Name}. Continue?", "Disenchant Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.No )
                            return;
                    }
                }
                else if ( loot.Type == "SKIN_RENTAL" && disenSkinsCheckbox.Checked )
                {
                    oe += loot.DisenchantValue; try
                    {
                        QsoApi.CraftRecipe( loot.Name, "SKIN_RENTAL_disenchant" );
                    }
                    catch ( QsoEndpointException )
                    {
                        if ( MessageBox.Show( $"Failed disenchanting loot item {loot.Name}. Continue?", "Disenchant Failed", MessageBoxButtons.YesNo, MessageBoxIcon.Error ) == DialogResult.No )
                            return;
                    }
                }
                // TODO: Wards
            }
            MessageBox.Show( $"Finished! The total disenchant was worth {be}BE and {oe}OE.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information );
        }
    }
}
