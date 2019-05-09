using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class ServiceStatusTickerMessage
    {
        [JsonProperty( "createdAt" )]
        public string CreatedAt { get; internal set; }
        [JsonProperty( "heading" )]
        public string Heading { get; internal set; }
        [JsonProperty( "message" )]
        public string Message { get; internal set; }
        [JsonProperty( "severity" )]
        public string Severity { get; internal set; }
        [JsonProperty( "updatedAt" )]
        public string UpdatedAt { get; internal set; }

        public DateTime GetCreatedAt()
        {
            return DateTime.Parse( CreatedAt );
        }

        public DateTime GetUpdatedAt()
        {
            return DateTime.Parse( UpdatedAt );
        }
    }
}
