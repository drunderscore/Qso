using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class LootRecipe
    {
        [JsonProperty( "contextMenuText" )]
        public string ContextMenuText { get; internal set; }
        [JsonProperty( "crafterName" )]
        public string CrafterName { get; internal set; }
        [JsonProperty( "description" )]
        public string Description { get; internal set; }
        [JsonProperty( "displayCategories" )]
        public string DisplayCategories { get; internal set; }
        [JsonProperty( "imagePath" )]
        public string ImagePath { get; internal set; }
        [JsonProperty( "outputs" )]
        public LootRecipeOutput[] Outputs { get; internal set; }
        [JsonProperty( "recipeName" )]
        public string RecipeName { get; internal set; }
        [JsonProperty( "type" )]
        public string Type { get; internal set; }
        [JsonProperty( "slots" )]
        public LootRecipeSlot[] Slots { get; internal set; }

        public override string ToString()
        {
            return $"{ContextMenuText}/{Description}/{RecipeName}";
        }
    }
}
