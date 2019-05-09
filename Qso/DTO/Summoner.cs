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
    public class Summoner
    {
        [JsonProperty( "accountId" )]
        public long AccountID { get; internal set; }
        [JsonProperty( "displayName" )]
        public string DisplayName { get; internal set; }
        [JsonProperty( "internalName" )]
        public string InternalName { get; internal set; }
        [JsonProperty( "puuid" )]
        public string PUUID { get; internal set; }
        [JsonProperty( "summonerId" )]
        public long ID { get; internal set; }
        [JsonProperty( "summonerLevel" )]
        public int Level { get; internal set; }

        private static string Escape( string str )
        {
            return str.Replace( "\"", "\\\"" );
        }

        public virtual ChatUser GetChatUser()
        {
            return QsoApi.GetDTO<ChatUser>( "/lol-chat/v1/friends/{0}", HttpMethod.Get, null, ID.ToString() );
        }
    }
}
