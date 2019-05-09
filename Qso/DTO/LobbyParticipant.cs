using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class LobbyParticipant
    {
        [JsonProperty( "summonerName" )]
        public string Name { get; internal set; }
        [JsonProperty( "summonerLevel" )]
        public int Level { get; internal set; }
        [JsonProperty( "teamId" )]
        public int TeamID { get; internal set; }
        [JsonProperty( "summonerInternalName" )]
        public string InternalName { get; internal set; }
        [JsonProperty( "summonerId" )]
        public int ID { get; internal set; }
        [JsonProperty( "summonerIconId" )]
        public int IconID { get; internal set; }
        [JsonProperty( "puuid" )]
        public string PUUID { get; internal set; }
        [JsonProperty( "ready" )]
        public bool Ready { get; internal set; }
        [JsonProperty( "firstPositionPreference" )]
        public string FirstPositionPreference { get; internal set; }
        [JsonProperty( "secondPositionPreference" )]
        public string SecondPositionPreference { get; internal set; }
        [JsonProperty( "isSpectator" )]
        public bool Spectator { get; internal set; }
        [JsonProperty( "isLeader" )]
        public bool Leader { get; internal set; }
        [JsonProperty( "isBot" )]
        public bool Bot { get; internal set; }
    }
}
