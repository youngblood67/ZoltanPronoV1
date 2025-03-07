using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class PlayerStatistics
    {

        [JsonProperty("games")]
        public Games Games { get; set; } = new Games(); 

        [JsonProperty("substitutes")]
        public Substitutes Substitutes { get; set; } = new Substitutes();   

        [JsonProperty("shots")]
        public Shots Shots { get; set; } = new Shots(); 

        [JsonProperty("goals")]
        public Goals Goals { get; set; } = new Goals(); 

        [JsonProperty("passes")]
        public Passes Passes { get; set; } = new Passes();  

        [JsonProperty("tackles")]
        public Tackles Tackles { get; set; } = new Tackles();   

        [JsonProperty("duels")]
        public Duels Duels { get; set; } = new Duels(); 

        [JsonProperty("dribbles")]
        public Dribbles Dribbles { get; set; } = new Dribbles();

        [JsonProperty("fouls")]
        public Fouls Fouls { get; set; } = new Fouls();

        [JsonProperty("cards")]
        public Cards Cards { get; set; } = new Cards(); 

        [JsonProperty("penalty")]
        public Penalty Penalty { get; set; } = new Penalty();   
    }
}
