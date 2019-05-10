using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso
{
    public class EndpointEventArgs : EventArgs
    {
        public string URI { get; }
        public string EventType { get; }
        public JToken JSON { get; }

        public EndpointEventArgs( string uri, string type, JToken data )
        {
            URI = uri;
            EventType = type;
            JSON = data;
        }
    }
}
