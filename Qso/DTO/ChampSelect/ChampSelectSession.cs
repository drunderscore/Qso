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
    public class ChampSelectSession
    {
        //[JsonProperty( "actions" )]
        //public ChampSelectAction[] Actions { get; internal set; }
        [JsonProperty( "allowBatleBoost" )]
        public bool AllowBatleBoost { get; internal set; }
        [JsonProperty( "allowDuplicatePicks" )]
        public bool AllowDuplicatePicks { get; internal set; }
        [JsonProperty( "allowLockedEvents" )]
        public bool AllowLockedEvents { get; internal set; }
        [JsonProperty( "allowRerolling" )]
        public bool AllowRerolling { get; internal set; }
        [JsonProperty( "allowSkinSelection" )]
        public bool AllowSkinSelection { get; internal set; }
        [JsonProperty( "bans" )]
        public ChampSelectBannedChampions Bans { get; internal set; }
        [JsonProperty( "benchChampionIds" )]
        public int[] BenchChampions { get; internal set; }
        [JsonProperty( "benchEnabled" )]
        public bool BenchEnabled { get; internal set; }
        [JsonProperty( "chatDetails" )]
        public ChampSelectChatRoomDetails ChatDetails { get; internal set; }
        [JsonProperty( "isSpectating" )]
        public bool Spectating { get; internal set; }
        [JsonProperty( "localPlayerCellId" )]
        public bool LocalPlayerCellID { get; internal set; }
        [JsonProperty( "myTeam" )]
        public ChampSelectPlayerSelection[] MyTeam { get; internal set; }
        [JsonProperty( "theirTeam" )]
        public ChampSelectPlayerSelection[] TheirTeam { get; internal set; }
        [JsonProperty( "timer" )]
        public ChampSelectTimer Timer { get; internal set; }

        public void SetSpell1( int id )
        {
            dynamic json = new JObject();
            json.spell1Id = id;
            QsoApi.Call( "/lol-champ-select/v1/session/my-selection", new HttpMethod( "PATCH" ), json.ToString() );
        }

        public void SetSpell2( int id )
        {
            dynamic json = new JObject();
            json.spell2Id = id;
            QsoApi.Call( "/lol-champ-select/v1/session/my-selection", new HttpMethod( "PATCH" ), json.ToString() );
        }

        public void SetSkin( int id )
        {
            dynamic json = new JObject();
            json.selectedSkinId = id;
            QsoApi.Call( "/lol-champ-select/v1/session/my-selection", new HttpMethod( "PATCH" ), json.ToString() );
        }

        public void SetWardSkin( int id )
        {
            dynamic json = new JObject();
            json.wardSkinId = id;
            QsoApi.Call( "/lol-champ-select/v1/session/my-selection", new HttpMethod( "PATCH" ), json.ToString() );
        }
    }
}
