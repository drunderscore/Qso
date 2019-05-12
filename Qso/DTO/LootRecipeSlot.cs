using Newtonsoft.Json;

namespace Qso.DTO
{
    public class LootRecipeSlot
    {
        [JsonProperty( "lootIds" )]
        public string[] LootIDs { get; internal set; }
        [JsonProperty( "quantity" )]
        public int Quantity { get; internal set; }
        [JsonProperty( "slotNumber" )]
        public int SlotNumber { get; internal set; }
        [JsonProperty( "tags" )]
        public string Tags { get; internal set; }
    }
}