using Newtonsoft.Json;

namespace Qso.DTO
{
    public class ChampSelectChatRoomDetails
    {
        [JsonProperty( "chatRoomName" )]
        public string RoomName { get; internal set; }
        [JsonProperty( "chatRoomPassword" )]
        public string RoomPassword { get; internal set; }
    }
}