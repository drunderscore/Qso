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
        public Queue[] queues;

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
            contentFilterTextbox.Text = string.Join( Environment.NewLine, QsoApi.GetContentFilters() );
            gameTypeCombo.Items.AddRange( Enum.GetNames( typeof( GameType ) ) );
            mapCombo.Items.AddRange( Enum.GetNames( typeof( MapID ) ) );
            botChampionCombo.Items.AddRange( Enum.GetNames( typeof( ChampionID ) ) );
            botChampionCombo.Sorted = true;
            botTeamCombo.Items.AddRange( Enum.GetNames( typeof( TeamID ) ) );
            queues = QsoApi.GetQueues();
            queueTypesCombo.DataSource = queues;
            queueTypesCombo.DisplayMember = "Name";
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

        private void createLobbyBtn_Click( object sender, EventArgs e )
        {
            if ( gameModeCombo.SelectedItem == null || gameTypeCombo.SelectedItem == null || mapCombo.SelectedItem == null || lobbyNameTextbox.Text == "" )
            {
                MessageBox.Show( "Missing required lobby configuration option.", "Value Missing", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            Lobby lobby = null;
            try
            {
                lobby = QsoApi.BuildLobby( lobbyNameTextbox.Text, gameModeCombo.Text, (GameType)Enum.Parse( typeof( GameType ), (string)gameTypeCombo.SelectedItem ), (MapID)Enum.Parse( typeof( MapID ), (string)mapCombo.SelectedItem ), Convert.ToInt32( teamSizeUpDown.Value ) ).Create();
            }
            catch ( QsoEndpointException ex )
            {
                MessageBox.Show( $"Unable to create a lobby with such configuration:\n{ex.ErrorResponse.Message}", "Endpoint Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }
        }

        private void addBotBtn_Click( object sender, EventArgs e )
        {
            if ( botChampionCombo.SelectedItem == null || botTeamCombo.SelectedItem == null || botDifficultyCombo.SelectedItem == null )
                return;
            Lobby lobby = null;
            try
            {
                lobby = QsoApi.GetMyLobby();
            }
            catch ( QsoEndpointException )
            {
                return; // lobby doesn't exist, no need for user response.
            }

            try
            {
                lobby.AddBot( (ChampionID)Enum.Parse( typeof( ChampionID ), (string)botChampionCombo.SelectedItem ), (TeamID)Enum.Parse( typeof( TeamID ), (string)botTeamCombo.SelectedItem ), (string)botDifficultyCombo.SelectedItem );
            }
            catch ( QsoEndpointException ex )
            {
                MessageBox.Show( $"Unable to add bot to lobby with such configuration:\n{ex.ErrorResponse.Message}", "Endpoint Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }

        private void queueBtn_Click( object sender, EventArgs e )
        {
            var selectedQueue = queues[queueTypesCombo.SelectedIndex];
            if ( selectedQueue != null )
            {
                try
                {
                    QsoApi.CreateLobby( (QueueType)selectedQueue.ID );
                }
                catch ( QsoEndpointException ex )
                {
                    MessageBox.Show( $"Unable to create a lobby with that queue:\n{ex.ErrorResponse.Message}", "Endpoint Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                }
            }
        }

        private void inviteSummonerBtn_Click( object sender, EventArgs e )
        {
            Lobby lobby = null;
            try
            {
                lobby = QsoApi.GetMyLobby();
            }
            catch ( QsoEndpointException ) { }

            Summoner sum = null;
            try
            {
                var found = QsoApi.GetSummonerByName( inviteSummonerTextbox.Text );
                if ( found.Length <= 0 )
                {
                    MessageBox.Show( "Unable to find summoner", "Missing", MessageBoxButtons.OK, MessageBoxIcon.Information );
                    return;
                }
                sum = found[0];
            }
            catch ( QsoEndpointException ex )
            {
                MessageBox.Show( $"Error trying to find summoner:\n{ex.ErrorResponse.Message}", "Endpoint Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                return;
            }

            lobby.Invite( sum.ID );
        }

        private void forceStartLobbyBtn_Click( object sender, EventArgs e )
        {
            try
            {
                QsoApi.GetMyLobby().StartChampSelect();
            }
            catch ( QsoEndpointException ) { }
        }

        private void forceLeaveLobbyBtn_Click( object sender, EventArgs e )
        {
            try
            {
                QsoApi.LeaveMyLobby();
            }
            catch ( QsoEndpointException ) { }
        }
    }
}
