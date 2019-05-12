using Newtonsoft.Json;

namespace Qso.DTO
{
    public class PlayerLootUpdate
    {
        [JsonProperty( "added" )]
        public PlayerLootDelta[] Added { get; internal set; }
        [JsonProperty( "redeemed" )]
        public PlayerLootDelta[] Redeemed { get; internal set; }
        [JsonProperty( "removed" )]
        public PlayerLootDelta[] Removed { get; internal set; }
    }
}