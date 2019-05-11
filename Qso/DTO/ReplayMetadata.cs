using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class ReplayMetadata
    {
        [JsonProperty( "downloadProgress" )]
        public string DownloadProgress { get; internal set; }
        [JsonProperty( "gameId" )]
        public long GameID { get; internal set; }
        [JsonProperty( "state" )]
        public string State { get; internal set; }
    }
}
