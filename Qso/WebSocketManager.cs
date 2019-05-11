using System;
using System.Security.Authentication;
using System.Text;
using WebSocketSharp;

namespace Qso
{
    public class WebSocketManager
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
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
            logger.Info( $"Connecting to {ip}:{port}" );
            WS = new WebSocket( $"wss://{ip}:{port}" );
            WS.SslConfiguration.EnabledSslProtocols = ( SslProtocols.Tls12 | SslProtocols.Tls11 );
            WS.SslConfiguration.ServerCertificateValidationCallback += QsoApi.RiotCertValidation;

            WS.SetCredentials( "riot", pass, true ); // Make sure to use preauth
            WS.Connect();
            Subscribe( "OnJsonApiEvent" );
        }

        private void Subscribe( string evt )
        {
            WS.Send( $"[5, \"{evt}\"]" );
        }
    }
}
