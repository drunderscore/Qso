using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class BuildInfo
    {
        [JsonProperty( "branch" )]
        public string Branch { get; internal set; }
        [JsonProperty( "pacthLine" )]
        public string PatchLine { get; internal set; }
        [JsonProperty( "patchlineVisibleName" )]
        public string PatchLineVisibleName { get; internal set; }
        [JsonProperty( "version" )]
        public string Version { get; internal set; }
    }
}
