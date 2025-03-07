using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class Response
    {
        [JsonProperty("fixture")]
        public Fixture Fixture { get; set; } = new  Fixture();  

        [JsonProperty("league")]
        public League League { get; set; } = new League();  

        [JsonProperty("teams")]
        public Teams Teams { get; set; } = new Teams(); 

        [JsonProperty("goals")]
        public Goals Goals { get; set; } = new Goals(); 

        [JsonProperty("score")]
        public ScoreBoard ScoreBoard { get; set; } = new ScoreBoard();  
    }
}
