using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Qso.DTO
{
    public class ChatUser
    {
        [JsonProperty( "availability" )]
        public string Availability { get; internal set; }
        [JsonProperty( "icon" )]
        public int Icon { get; internal set; }
        [JsonProperty( "id" )]
        public int ID { get; internal set; }
        [JsonProperty( "name" )]
        public string Name { get; internal set; }
        [JsonProperty( "statusMessage" )]
        public string StatusMessage { get; internal set; }
        [JsonProperty( "note" )]
        public string Note { get; internal set; }
        [JsonProperty( "lol" )]
        public ChatUserResourceLoL LoL { get; internal set; }
        [JsonProperty( "groupId" )]
        public int GroupID { get; internal set; }

        public virtual void SendMessage( string message )
        {
            dynamic json = new JObject();
            json.body = message;
            QsoApi.Call( "/lol-chat/v1/conversations/{0}/messages", HttpMethod.Post, json.ToString(), ID );
        }
    }
}
