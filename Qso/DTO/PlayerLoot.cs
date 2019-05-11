using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class PlayerLoot
    {
        [JsonProperty( "asset" )]
        public string Asset { get; internal set; }
        [JsonProperty( "count" )]
        public int Count { get; internal set; }
        [JsonProperty( "displayCategories" )]
        public string DisplayCategories { get; internal set; }
        [JsonProperty( "expiryTime" )]
        public int ExpiryTime { get; internal set; }
        [JsonProperty( "lootName" )]
        public string Name { get; internal set; }
        [JsonProperty( "rarity" )]
        public string Rarity { get; internal set; }
        [JsonProperty( "storeItemId" )]
        public int StoreItemID { get; internal set; }
        [JsonProperty( "tags" )]
        public string Tags { get; internal set; }
        [JsonProperty( "type" )]
        public string Type { get; internal set; }
        [JsonProperty( "upgradeLootName" )]
        public string UpgradeLootName { get; internal set; }
        [JsonProperty( "disenchantValue" )]
        public int DisenchantValue { get; internal set; }
        [JsonProperty( "itemDesc" )]
        public string Description { get; internal set; }
        [JsonProperty( "itemStatus" )]
        public string Status { get; internal set; }
        [JsonProperty( "localizedDescription" )]
        public string LocalizedDescription { get; internal set; }
        [JsonProperty( "localizedName" )]
        public string LocalizedName { get; internal set; }
        [JsonProperty( "localizedRecipeSubtitle" )]
        public string LocalizedRecipeSubtitle { get; internal set; }
        [JsonProperty( "localizedRecipeTitle" )]
        public string LocalizedRecipeTitle { get; internal set; }
        [JsonProperty( "refId" )]
        public string RefID { get; internal set; }
        [JsonProperty( "lootId" )]
        public string ID { get; internal set; }
        [JsonProperty( "splashPath" )]
        public string SplashPath { get; internal set; }
        [JsonProperty( "tilePath" )]
        public string TilePath { get; internal set; }
        [JsonProperty( "redeemableStatus" )]
        public string RedeemableStatus { get; internal set; }


        public string[] GetTags()
        {
            return Tags.Split( ',' );
        }
    }
}
