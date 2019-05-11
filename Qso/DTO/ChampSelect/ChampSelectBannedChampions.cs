using Newtonsoft.Json;

namespace Qso.DTO
{
    public class ChampSelectBannedChampions
    {
        [JsonProperty( "myTeamBans" )]
        public int[] MyTeamBans { get; internal set; }
        [JsonProperty( "numBans" )]
        public int NumBans { get; internal set; }
        [JsonProperty( "theirTeamBans" )]
        public int[] TheirTeamBans { get; internal set; }
    }
}