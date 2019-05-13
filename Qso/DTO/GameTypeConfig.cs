using Newtonsoft.Json;

namespace Qso.DTO
{
    public class GameTypeConfig
    {
        [JsonProperty( "allowTrades" )]
        public bool AllowTrades { get; internal set; }
        [JsonProperty( "banMode" )]
        public string BanMode { get; internal set; }
        [JsonProperty( "banTimerDuration" )]
        public int BanDuration { get; internal set; }
        [JsonProperty( "crossTeamChampionPool" )]
        public bool CrossTeamChampionPool { get; internal set; }
        [JsonProperty( "deathMatch" )]
        public bool DeathMatch { get; internal set; }
        [JsonProperty( "doNotRemove" )]
        public bool DoNotRemove { get; internal set; }
        [JsonProperty( "duplicatePick" )]
        public bool DuplicatePick { get; internal set; }
        [JsonProperty( "exclusivePick" )]
        public bool ExclusivePick { get; internal set; }
        [JsonProperty( "id" )]
        public int ID { get; internal set; }
        [JsonProperty( "mainPickTimerDuration" )]
        public int PickTimerDuration { get; internal set; }
        [JsonProperty( "maxAllowableBans" )]
        public int MaxAllowableBans { get; internal set; }
        [JsonProperty( "name" )]
        public string Name { get; internal set; }
        [JsonProperty( "pickMode" )]
        public string PickMode { get; internal set; }
        [JsonProperty( "postPickTimerDuration" )]
        public int PostPickTimerDuration { get; internal set; }
        [JsonProperty( "reroll" )]
        public bool Reroll { get; internal set; }
        [JsonProperty( "teamChampionPool" )]
        public bool TeamChampionPool { get; internal set; }
    }
}