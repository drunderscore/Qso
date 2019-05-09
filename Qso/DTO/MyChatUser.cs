using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class MyChatUser : ChatUser
    {
        public override void SendMessage( string message )
        {
            throw new QsoException( "Cannot send a message to yourself." );
        }
        /// <summary>
        /// Sets the users status message. The client maximum is 25 characters, however the endpoint maximum is 50 characters.
        /// </summary>
        public void SetStatusMessage( string message )
        {
            dynamic json = new JObject();
            json.statusMessage = message;
            QsoApi.Call( "/lol-chat/v1/me", HttpMethod.Put, json.ToString() );
        }

        public void SetAvailability( string avail )
        {
            dynamic json = new JObject();
            json.availability = avail;
            QsoApi.Call( "/lol-chat/v1/me", HttpMethod.Put, json.ToString() );
        }
    }
}
