using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class LobbyGameConfig
    {
        [JsonProperty( "queueId" )]
        public int QueueID { get; internal set; }
        [JsonProperty( "customLobbyName" )]
        public string LobbyName { get; internal set; }
        [JsonProperty( "customMutatorName" )]
        public string MutatorName { get; internal set; }
        [JsonProperty( "customSpectatorPolicy" )]
        public string SpectatorPolicy { get; internal set; }
        [JsonProperty( "isCustom" )]
        public bool Custom { get; internal set; }
        [JsonProperty( "isLobbyFull" )]
        public bool Full { get; internal set; }
        [JsonProperty( "mapId" )]
        public int MapID { get; internal set; }
        [JsonProperty( "maxHumanPlayers" )]
        public int MaxHumanPlayers { get; internal set; }
        [JsonProperty( "maxLobbySize" )]
        public int MaxLobbySize { get; internal set; }
        [JsonProperty( "maxTeamSize" )]
        public int MaxTeamSize { get; internal set; }
        [JsonProperty( "pickType" )]
        public string PickType { get; internal set; }
        [JsonProperty( "gameMode" )]
        public string GameMode { get; internal set; }
        [JsonProperty( "customSpectators" )]
        public LobbyParticipant[] Spectators { get; internal set; }
        [JsonProperty( "customTeam100" )]
        public LobbyParticipant[] Team1 { get; internal set; }
        [JsonProperty( "customTeam200" )]
        public LobbyParticipant[] Team2 { get; internal set; }
    }
}
