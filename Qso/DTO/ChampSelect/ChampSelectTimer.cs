using Newtonsoft.Json;

namespace Qso.DTO
{
    public class ChampSelectTimer
    {
        [JsonProperty( "adjustedTimeLeftInPhase" )]
        public int AdjustedTimeLeft { get; internal set; }
        [JsonProperty( "adjustedTimeLetInPhaseInSec" )]
        public int AdjustedTimeLeftInSeconds { get; internal set; }
        // The documentation doesn't label this as a long, but obviously it should be, right?
        [JsonProperty( "internalNowInEpochMs" )]
        public long InternalEpoch { get; internal set; }
        [JsonProperty( "isInfinite" )]
        public bool Infinite { get; internal set; }
        [JsonProperty( "phase" )]
        public string Phase { get; internal set; }
        [JsonProperty( "timeLeftInPhase" )]
        public int TimeLeft { get; internal set; }
        [JsonProperty( "timeLeftInPhaseInSec" )]
        public int TimeLeftInSeconds { get; internal set; }
    }
}