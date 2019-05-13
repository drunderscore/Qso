using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class PerkPageResource
    {
        [JsonProperty( "autoModifiedSelections" )]
        public int[] AutoModifiedSelections { get; internal set; }
        [JsonProperty( "current" )]
        public bool Current { get; internal set; }
        [JsonProperty( "id" )]
        public long ID { get; internal set; }
        [JsonProperty( "isActive" )]
        public bool Active { get; internal set; }
        [JsonProperty( "isDeletable" )]
        public bool Deletable { get; internal set; }
        [JsonProperty( "isEditable" )]
        public bool Editable { get; internal set; }
        [JsonProperty( "isValid" )]
        public bool Valid { get; internal set; }
        [JsonProperty( "lastModified" )]
        public long LastModified { get; internal set; }
        [JsonProperty( "name" )]
        public string Name { get; internal set; }
        [JsonProperty( "order" )]
        public int Order { get; internal set; }
        [JsonProperty( "primaryStyleId" )]
        public int PrimaryStyle { get; internal set; }
        [JsonProperty( "selectedPerkIds" )]
        public int[] SelectedPerks { get; internal set; }
        [JsonProperty( "subStyleId" )]
        public int SubStyle { get; internal set; }

        public PerkPageBuilder Modify()
        {
            return new PerkPageBuilder( ID );
        }
    }
}
