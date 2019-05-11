using Qso;
using Qso.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QsoClient
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load( object sender, EventArgs e )
        {

        }

        private void button1_Click( object sender, EventArgs e )
        {
            var session = QsoApi.GetMyChampSelect();
            ChampionID champ;
            if ( !Enum.TryParse( textBox1.Text, true, out champ ) )
                return;
            session.GetNextActionForCell( session.LocalPlayerCellID ).Execute( champ, true );
        }

        private void button2_Click( object sender, EventArgs e )
        {
            var session = QsoApi.GetMyChampSelect();
            label1.Text = session.GetNextActionForCell( session.LocalPlayerCellID ).Type;
        }
    }
}
