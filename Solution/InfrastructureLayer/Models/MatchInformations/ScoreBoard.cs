using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class ScoreBoard
    {
        [JsonProperty("fulltime")]
        public FullTimeScore FullTimeScore { get; set; } = new FullTimeScore(); 
        [JsonProperty("halftime")]
        public HalfTimeScore HalfTimeScore { get; set; } = new HalfTimeScore(); 
        [JsonProperty("extratime")]
        public ExtraTimeScore ExtraTimeScore { get; set; } = new ExtraTimeScore();  
        [JsonProperty("penalty")]
        public PenaltyScore PenaltyScore { get; set; } = new PenaltyScore();    
    }
}