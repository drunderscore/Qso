using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class Queue
    {
        [JsonProperty( "allowablePremadeSizes" )]
        public int[] AllowablePremadeSizes { get; internal set; }
        [JsonProperty( "areFreeChampionsAllowed" )]
        public bool FreeChampionsAllowed { get; internal set; }
        [JsonProperty( "assetMutator" )]
        public string AssetMutator { get; internal set; }
        [JsonProperty( "caegory" )]
        public string Category { get; internal set; }
        [JsonProperty( "championsRequiredToPlay" )]
        public int ChampionsRequired { get; internal set; }
        [JsonProperty( "description" )]
        public string Description { get; internal set; }
        [JsonProperty( "detailedDescription" )]
        public string DetailedDescription { get; internal set; }
        [JsonProperty( "gameMode" )]
        public string GameMode { get; internal set; }
        [JsonProperty( "gameTypeConfig" )]
        public GameTypeConfig GameTypeConfig { get; internal set; }
        [JsonProperty( "id" )]
        public int ID { get; internal set; }
        [JsonProperty( "isRanked" )]
        public bool Ranked { get; internal set; }
        [JsonProperty( "isTeamBuilderManaged" )]
        public bool TeamBuilderManaged { get; internal set; }
        [JsonProperty( "isTeamOnly" )]
        public bool TeamOnly { get; internal set; }
        [JsonProperty( "mapId" )]
        public MapID Map { get; internal set; }
        [JsonProperty( "maxLevel" )]
        public int MaxLevel { get; internal set; }
        [JsonProperty( "minLevel" )]
        public int MinLevel { get; internal set; }
        [JsonProperty( "name" )]
        public string Name { get; internal set; }
        [JsonProperty( "numPlayersPerTeam" )]
        public int TeamSize { get; internal set; }
        [JsonProperty( "queueAvailability" )]
        public string QueueAvailability { get; internal set; }
        [JsonProperty( "shortName" )]
        public string ShortName { get; internal set; }
        [JsonProperty( "showPositionSelector" )]
        public bool ShowPositionSelector { get; internal set; }
        [JsonProperty( "spectatorEnabled" )]
        public bool Spectator { get; internal set; }
        [JsonProperty( "type" )]
        public string Type { get; internal set; }
    }
}
