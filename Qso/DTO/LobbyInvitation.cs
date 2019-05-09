using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class LobbyInvitation
    {
        [JsonProperty( "invitationId" )]
        public string InvitationID { get; internal set; }
        [JsonProperty( "state" )]
        public string State { get; internal set; }
        [JsonProperty( "timestamp" )]
        public string Timestamp { get; internal set; }
        [JsonProperty( "toSummonerId" )]
        public int ToSummonerID { get; internal set; }
        [JsonProperty( "toSummonerName" )]
        public string ToSummonerName { get; internal set; }
    }
}
