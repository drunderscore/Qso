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

        private void button1_Click( object sender, EventArgs e )
        {
            QueueType id;
            if ( Enum.TryParse( textBox1.Text, out id ) )
                QsoApi.CreateLobby( id );
        }
    }
}
