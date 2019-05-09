using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;

namespace Qso.DTO
{
    public class LobbyBuilder
    {
        public dynamic JSON { get; internal set; }

        public LobbyBuilder( string lobbyName, string gamemode, GameType gametype, MapID mapId, int teamSize )
        {
            JSON = new JObject();
            JSON.customGameLobby = new JObject();
            JSON.customGameLobby.configuration = new JObject();
            JSON.customGameLobby.configuration.gameTypeConfig = new JObject();

            JSON.isCustom = true;
            JSON.customGameLobby.lobbyName = lobbyName;
            JSON.customGameLobby.configuration.gameMode = gamemode;
            JSON.customGameLobby.configuration.mapId = mapId;
            JSON.customGameLobby.configuration.teamSize = teamSize;
            JSON.customGameLobby.configuration.gameTypeConfig.id = gametype;
        }

        public LobbyBuilder WithSpectatorPolicy( string policy )
        {
            JSON.customGameLobby.configuration.spectatorPolicy = policy;
            return this;
        }

        public LobbyBuilder WithPassword( string pass )
        {
            JSON.customGameLobby.lobbyPassword = pass;
            return this;
        }

        public Lobby Create()
        {
            Console.WriteLine( JSON.ToString() );
            return QsoApi.GetDTO<Lobby>( "/lol-lobby/v2/lobby", HttpMethod.Post, JSON.ToString() );
        }
    }
}