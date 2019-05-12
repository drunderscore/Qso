using Newtonsoft.Json;

namespace Qso.DTO
{
    public class PlayerLootDelta
    {
        [JsonProperty( "deltaCount" )]
        public int DeltaCount { get; internal set; }
        [JsonProperty( "playerLoot" )]
        public PlayerLoot Loot { get; internal set; }
    }
}