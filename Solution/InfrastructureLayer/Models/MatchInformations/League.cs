using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class League
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;    

        [JsonProperty("country")]
        public string Country { get; set; } = string.Empty; 

        [JsonProperty("season")]
        public string Season { get; set; } = string.Empty;  

        [JsonProperty("round")]
        public string Round { get; set; } = string.Empty;
    }
}