using Qso;
using Qso.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QsoClient
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault( false );
            QsoApi.Initialize();
            //foreach ( ChatUser cu in QsoApi.GetMyFriends() )
            //{
            //    Console.WriteLine( cu.Name + " / " + cu.ID );
            //}
            //QsoApi.SendFriendRequest( 12 );
            //QsoApi.SendFriendRequest( "Die" );
            //var lobby = QsoApi.GetMyLobby();
            //lobby.Invite( QsoApi.GetSummonerByID( 102660481 ) );
            Application.Run( new MainWindow() );
        }
    }
}
