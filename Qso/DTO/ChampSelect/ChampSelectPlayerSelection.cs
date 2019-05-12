using Newtonsoft.Json;

namespace Qso.DTO
{
    public class ChampSelectPlayerSelection
    {
        [JsonProperty( "assignedPosition" )]
        public string AssignedPosition { get; internal set; }
        [JsonProperty( "cellId" )]
        public int CellID { get; internal set; }
        [JsonProperty( "championId" )]
        public ChampionID ChampionID { get; internal set; }
        [JsonProperty( "championPickIntent" )]
        public int ChampionIntentID { get; internal set; }
        /// <summary>
        /// This should be either PLAYER or BOT
        /// </summary>
        [JsonProperty( "playerType" )]
        public string PlayerType { get; internal set; }
        [JsonProperty( "spell1Id" )]
        public long Spell1ID { get; internal set; }
        [JsonProperty( "spell2Id" )]
        public long Spell2ID { get; internal set; }
        [JsonProperty( "selectedSkinId" )]
        public int SelectedSkinID { get; internal set; }
        [JsonProperty( "summonerId" )]
        public int SummonerID { get; internal set; }
        [JsonProperty( "team" )]
        public int Team { get; internal set; }
        [JsonProperty( "wardSkinId" )]
        public int WardSkinID { get; internal set; }
    }
}