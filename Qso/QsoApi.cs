using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Qso.DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;

namespace Qso
{
    public class QsoApi
    {
        #region Ugly DllImports
        [DllImport( "ProcCmdLine32.dll", CharSet = CharSet.Unicode, EntryPoint = "GetProcCmdLine" )]
        private extern static bool GetProcCmdLine32( uint nProcId, StringBuilder sb, uint dwSizeBuf );
        [DllImport( "ProcCmdLine64.dll", CharSet = CharSet.Unicode, EntryPoint = "GetProcCmdLine" )]
        private extern static bool GetProcCmdLine64( uint nProcId, StringBuilder sb, uint dwSizeBuf );

        #endregion
        private static WebSocketManager WSManager { get; set; }
        private static HttpClient Client { get; set; }

        private static readonly string LEAGUE_CERT_THUMBPRINT = "8259aafd8f71a809d2b154dd1cdb492981e448bd";
        private static readonly Regex _cmdLineRegex = new Regex( "\"--([a-z-]+|-)=([^\"]+)\"" ); // without escapes: "--([a-z-]+|-)=([^"]+)"
        public static readonly RemoteCertificateValidationCallback RiotCertValidation = ( sender, cert, chain, sslPolErrors ) => { return sslPolErrors == SslPolicyErrors.None || cert.GetCertHashString().ToLower() == LEAGUE_CERT_THUMBPRINT; };

        #region Qso Creation

        public static void Initialize( int port, string password )
        {
            Initialize( "127.0.0.1", port, password );
        }

        public static void Initialize( string ip, int port, string password )
        {
            ServicePointManager.ServerCertificateValidationCallback += RiotCertValidation;
            Client = new HttpClient();
            WSManager = new WebSocketManager( ip, port, password );
            var build = GetBuild();
            Console.WriteLine( $"Qso initialized. Branch {build.Branch}, Version {build.Version}" );
        }

        public static void Initialize()
        {
            Process[] leaguesRunning = Process.GetProcessesByName( "LeagueClientUx" );
            if ( leaguesRunning.Length <= 0 )
                throw new QsoException( "The League Client must be running." );
            if ( leaguesRunning.Length > 1 )
                throw new QsoException( "Qso cannot be used whilst multiple League Client processes are running." );

            var p = leaguesRunning[0];

            var mc = _cmdLineRegex.Matches( GetCommandLineOfProcess( p ) );
            var uxArgs = mc.Cast<Match>().ToDictionary( m => m.Groups[1].Value, m => m.Groups[2].Value );
            string[] lockfileArgs;

            using ( var fs = new FileStream( $"{uxArgs["install-directory"]}/lockfile", FileMode.Open, FileAccess.Read, FileShare.ReadWrite ) )
            using ( var sr = new StreamReader( fs, Encoding.Default ) )
                lockfileArgs = sr.ReadToEnd().Split( ':' );

            Initialize( "127.0.0.1", int.Parse( uxArgs["app-port"] ), lockfileArgs[3] );
        }
        #endregion

        #region DTO Helpers
        public static string Call( string path, HttpMethod method, string body = null, params string[] parameters )
        {
            string finalPath = $"https://127.0.0.1:{WSManager.Port}{string.Format( path, parameters )}";
            Console.WriteLine( $"Requesting {finalPath} ({method.Method})" );

            using ( HttpRequestMessage req = new HttpRequestMessage( method, new Uri( finalPath ) ) )
            {
                req.Headers.Add( "Authorization", $"Basic { WSManager.AuthToken }" );
                req.Headers.Add( "Accept", "application/json" );
                if ( body != null )
                {
                    req.Content = new StringContent( body, Encoding.UTF8 );
                    req.Content.Headers.ContentType.MediaType = "application/json";
                }
                using ( HttpResponseMessage resp = Client.SendAsync( req ).Result )
                {
                    string res = resp.Content.ReadAsStringAsync().Result;
                    Console.WriteLine( $"RESPONSE: {res}" );
                    return res;
                }
            }
        }

        public static T GetDTO<T>( string path, HttpMethod method, string body = null, params string[] parameters )
        {
            return JsonConvert.DeserializeObject<T>( Call( path, method, body, parameters ) );
        }
        #endregion

        #region DTOs
        public static MySummoner GetMySummoner()
        {
            return GetDTO<MySummoner>( "/lol-summoner/v1/current-summoner", HttpMethod.Get );
        }

        public static MyChatUser GetMyChatUser()
        {
            return GetDTO<MyChatUser>( "/lol-chat/v1/me", HttpMethod.Get, null );
        }

        public static ChatUser[] GetMyFriends()
        {
            return GetDTO<ChatUser[]>( "/lol-chat/v1/friends", HttpMethod.Get );
        }

        public static Lobby GetMyLobby()
        {
            return GetDTO<Lobby>( "/lol-lobby/v2/lobby", HttpMethod.Get );
        }

        public static void LeaveMyLobby()
        {
            Call( "/lol-lobby/v2/lobby", HttpMethod.Delete );
        }

        public static Lobby CreateLobby( QueueType queueId )
        {
            dynamic json = new JObject();
            json.queueId = queueId;
            return GetDTO<Lobby>( "/lol-lobby/v2/lobby", HttpMethod.Post, json.ToString() );
        }

        public static LobbyBuilder BuildLobby( string lobbyName, string gamemode, GameType gametype, MapID mapId, int teamSize )
        {
            return new LobbyBuilder( lobbyName, gamemode, gametype, mapId, teamSize );
        }

        public static ServiceStatusTickerMessage[] GetTickerMessages()
        {
            return GetDTO<ServiceStatusTickerMessage[]>( "/lol-service-status/v1/ticker-messages", HttpMethod.Get );
        }

        public static void SendFriendRequest( int id )
        {
            dynamic json = new JObject();
            json.id = id;
            Call( "/lol-chat/v1/friend-requests", HttpMethod.Post, json.ToString() );
        }

        public static void SendFriendRequest( string name )
        {
            dynamic json = new JObject();
            json.name = name;
            Call( "/lol-chat/v1/friend-requests", HttpMethod.Post, json.ToString() );
        }

        public static void RevokeFriendRequest( int id )
        {
            Call( "/lol-chat/v1/friend-requests/{0}", HttpMethod.Delete, null, id.ToString() );
        }

        public static void RemoveFriend( int id )
        {
            Call( "/lol-chat/v1/friends/{0}", HttpMethod.Delete, null, id.ToString() );
        }

        public static Summoner GetSummonerByID( long id )
        {
            return GetDTO<Summoner>( "/lol-summoner/v1/summoners/{0}", HttpMethod.Get, null, id.ToString() );
        }

        public static Summoner GetSummonerByName( string name )
        {
            dynamic json = new JObject();
            json.name = name;
            return GetDTO<Summoner>( "/lol-summoner/v2/summoners", HttpMethod.Get, json.ToString() );
        }

        public static BuildInfo GetBuild()
        {
            return GetDTO<BuildInfo>( "/system/v1/builds", HttpMethod.Get );
        }
        #endregion

        // Thanks https://stackoverflow.com/a/46006415
        private static string GetCommandLineOfProcess( Process proc )
        {
            // max size of a command line is USHORT/sizeof(WCHAR), so we are going
            // just allocate max USHORT for sanity's sake.
            var sb = new StringBuilder( 0xFFFF );
            switch ( IntPtr.Size )
            {
                case 4:
                    GetProcCmdLine32( (uint)proc.Id, sb, (uint)sb.Capacity );
                    break;
                case 8:
                    GetProcCmdLine64( (uint)proc.Id, sb, (uint)sb.Capacity );
                    break;
            }
            return sb.ToString();
        }
    }
}
