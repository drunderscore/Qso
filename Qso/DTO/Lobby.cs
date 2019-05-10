using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class Lobby
    {
        [JsonProperty( "chatRoomId" )]
        public string ChatRoomID { get; internal set; }
        [JsonProperty( "chatRoomKey" )]
        public string ChatRoomKey { get; internal set; }
        [JsonProperty( "localMember" )]
        public LobbyParticipant LocalMember { get; internal set; }
        [JsonProperty( "members" )]
        public LobbyParticipant[] Members { get; internal set; }
        [JsonProperty( "partyId" )]
        public string PartyID { get; internal set; }
        [JsonProperty( "partyType" )]
        public string PartyType { get; internal set; }
        [JsonProperty( "gameConfig" )]
        public LobbyGameConfig GameConfig { get; internal set; }

        public LobbyInvitation[] GetInvitations()
        {
            return QsoApi.GetDTO<LobbyInvitation[]>( "/lol-lobby/v2/lobby/invitations", HttpMethod.Get );
        }

        public LobbyInvitation[] Invite( Summoner s )
        {
            dynamic obj = new JObject();
            obj.toSummonerId = s.ID;
            dynamic json = new JArray( obj );
            return QsoApi.GetDTO<LobbyInvitation[]>( "/lol-lobby/v2/lobby/invitations", HttpMethod.Post, json.ToString() );
        }

        public LobbyInvitation[] Invite( string name )
        {
            dynamic obj = new JObject();
            obj.toSummonerName = name;
            dynamic json = new JArray( obj );
            return QsoApi.GetDTO<LobbyInvitation[]>( "/lol-lobby/v2/lobby/invitations", HttpMethod.Post, json.ToString() );
        }

        public void StartChampSelect()
        {
            QsoApi.Call( "/lol-lobby/v1/lobby/custom/start-champ-select", HttpMethod.Post );
        }

        public void StopChampSelect()
        {
            QsoApi.Call( "/lol-lobby/v1/lobby/custom/cancel-champ-select", HttpMethod.Post );
        }

        public void Kick( Summoner s )
        {
            QsoApi.Call( "/lol-lobby/v2/lobby/members/{0}/kick", HttpMethod.Post, null, s.ID.ToString() );
        }

        public void Promote( Summoner s )
        {
            QsoApi.Call( "/lol-lobby/v2/lobby/members/{0}/promote", HttpMethod.Post, null, s.ID.ToString() );
        }

        public void AddBot( ChampionID champion, TeamID team, string difficulty )
        {
            dynamic json = new JObject();
            json.championId = champion;
            json.teamId = team.ToString();
            json.botDifficulty = difficulty;
            QsoApi.Call( "/lol-lobby/v1/lobby/custom/bots", HttpMethod.Post, json.ToString() );
        }

        public void StopQueue()
        {
            QsoApi.Call( "/lol-lobby/v2/lobby/matchmaking/search", HttpMethod.Delete );
        }

        /// <summary>
        /// This will reset the position you do not specify. Specify both at once to set both.
        /// </summary>
        public void SetPositionPreferences( string primary = null, string secondary = null )
        {
            dynamic json = new JObject();
            if ( primary != null )
                json.firstPreference = secondary;
            if ( secondary != null )
                json.secondPreference = secondary;
            QsoApi.Call( "/lol-lobby/v2/lobby/members/localMember/position-preferences", HttpMethod.Put, json );
        }

        public void StartQueue()
        {
            QsoApi.Call( "/lol-lobby/v2/lobby/matchmaking/search", HttpMethod.Post );
        }
    }
}
