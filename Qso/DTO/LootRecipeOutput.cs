using Newtonsoft.Json;

namespace Qso.DTO
{
    public class LootRecipeOutput
    {
        [JsonProperty( "lootName" )]
        public string LootName { get; internal set; }
        [JsonProperty( "quantity" )]
        public int Quantity { get; internal set; }
    }
}