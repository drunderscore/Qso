using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class ChatUserResourceLoL
    {
        [JsonProperty( "championId" )]
        public string ChampionID { get; internal set; }
        [JsonProperty( "gameId" )]
        public string GameID { get; internal set; }
        [JsonProperty( "gameMode" )]
        public string GameMode { get; internal set; }
        [JsonProperty( "gameQueueType" )]
        public string GameQueueType { get; internal set; }
        [JsonProperty( "gameStatus" )]
        public string GameStatus { get; internal set; }
        [JsonProperty( "isObservable" )]
        public string Observable { get; internal set; }
        [JsonProperty( "level" )]
        public string Level { get; internal set; }
        [JsonProperty( "mapId" )]
        public string MapID { get; internal set; }
        [JsonProperty( "pty" )]
        public string Party { get; internal set; }
        [JsonProperty( "queueId" )]
        public int Queue { get; internal set; }
        [JsonProperty( "rankedLeagueDivision" )]
        public string RankedLeagueDivision { get; internal set; }
        [JsonProperty( "rankedLeagueQueue" )]
        public string RankedLeagueQueue { get; internal set; }
        [JsonProperty( "rankedLeagueTier" )]
        public string RankedLeagueTier { get; internal set; }
    }
}
