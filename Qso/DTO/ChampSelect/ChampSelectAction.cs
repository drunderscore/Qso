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
    public class ChampSelectAction
    {
        [JsonProperty( "actorCellId" )]
        public int ActorCellID { get; internal set; }
        [JsonProperty( "championId" )]
        public ChampionID ChampionID { get; internal set; }
        [JsonProperty( "completed" )]
        public bool Completed { get; internal set; }
        [JsonProperty( "id" )]
        public int ID { get; internal set; }
        [JsonProperty( "pickTurn" )]
        public int PickTurn { get; internal set; }
        [JsonProperty( "type" )]
        public string Type { get; internal set; }

        // TODO: Should we not call if it is already completed, or allow calling it anyway?
        public void Execute( ChampionID champ, bool completed = true )
        {
            dynamic json = new JObject();
            json.championId = champ;
            json.completed = completed;
            QsoApi.Call( "/lol-champ-select/v1/session/actions/{0}", new HttpMethod( "PATCH" ), json.ToString(), ID.ToString() );
        }
    }
}
