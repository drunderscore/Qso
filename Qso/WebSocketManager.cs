using System;
using System.Security.Authentication;
using System.Text;
using WebSocketSharp;

namespace Qso
{
    public class WebSocketManager
    {
        public WebSocket WS { get; }
        public string IP { get; }
        public int Port { get; }
        public string Password { get; }
        public string AuthToken
        {
            get
            {
                return Convert.ToBase64String( Encoding.UTF8.GetBytes( $"riot:{Password}" ) );
            }
        }

        public WebSocketManager( string ip, int port, string pass )
        {
            IP = ip;
            Port = port;
            Password = pass;
            Console.WriteLine( $"Connecting to {ip}:{port}" );
            WS = new WebSocket( $"wss://{ip}:{port}" );
            WS.SslConfiguration.EnabledSslProtocols = ( SslProtocols.Tls12 | SslProtocols.Tls11 );
            WS.SslConfiguration.ServerCertificateValidationCallback += QsoApi.RiotCertValidation;
            WS.OnOpen += OnOpen;
            WS.OnMessage += OnMessage;
            WS.OnClose += OnClose;
            WS.OnError += OnError;

            WS.SetCredentials( "riot", pass, true ); // Make sure to use preauth
            WS.Connect();
            Subscribe( "OnJsonApiEvent" );
        }

        private void Subscribe( string evt )
        {
            WS.Send( $"[5, \"{evt}\"]" );
        }

        private void OnError( object sender, ErrorEventArgs e )
        {
            Console.WriteLine( "WebSocket error! " + e.Message );
        }

        private void OnClose( object sender, CloseEventArgs e )
        {
            Console.WriteLine( "WebSocket close! code " + e.Code + ": " + e.Reason + " (wasClean " + e.WasClean + ")" );
        }

        private void OnMessage( object sender, MessageEventArgs e )
        {
            Console.WriteLine( "OnMessage data: " + e.Data );
        }

        private void OnOpen( object sender, EventArgs e )
        {
            Console.WriteLine( "WebSocket opened." );
        }
    }
}
