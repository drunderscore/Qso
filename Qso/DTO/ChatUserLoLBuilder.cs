using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class ChatUserLoLBuilder
    {
        private ChatUser _user;
        public ChatUserLoLBuilder()
        {
            _user = QsoApi.GetMyChatUser();
        }

        public ChatUserLoLBuilder WithChampion( ChampionID champ )
        {
            _user.LoL.ChampionID = ( (int)champ ).ToString();
            return this;
        }

        public ChatUserLoLBuilder WithGameStatus( string status )
        {
            _user.LoL.GameStatus = status;
            return this;
        }

        public ChatUserLoLBuilder WithGameMode( string gamemode )
        {
            _user.LoL.GameMode = gamemode;
            return this;
        }

        public ChatUserLoLBuilder WithGameQueueType( string type )
        {
            _user.LoL.GameQueueType = type;
            return this;
        }

        public ChatUserLoLBuilder WithRankedLeague( string name )
        {
            _user.LoL.RankedLeagueTier = name;
            return this;
        }

        public ChatUserLoLBuilder WithRankedDivision( string div )
        {
            _user.LoL.RankedLeagueDivision = div;
            return this;
        }

        public ChatUserLoLBuilder WithParty( string party )
        {
            _user.LoL.Party = party;
            return this;
        }

        public ChatUser Build()
        {
            return QsoApi.GetDTO<ChatUser>( "/lol-chat/v1/me", HttpMethod.Put, JsonConvert.SerializeObject( _user ) );
        }
    }
}
