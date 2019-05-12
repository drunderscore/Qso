using Newtonsoft.Json;

namespace Qso.DTO
{
    public class ChampSelectBannedChampions
    {
        [JsonProperty( "myTeamBans" )]
        public ChampionID[] MyTeamBans { get; internal set; }
        [JsonProperty( "numBans" )]
        public int NumBans { get; internal set; }
        [JsonProperty( "theirTeamBans" )]
        public ChampionID[] TheirTeamBans { get; internal set; }
    }
}