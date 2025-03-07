using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Games
    {
        [JsonProperty("appearences")]
        public int? Appearances { get; set; }

        [JsonProperty("lineups")]
        public int? Lineups { get; set; }

        [JsonProperty("minutes")]
        public int? Minutes { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; } = string.Empty;

        [JsonProperty("rating")]
        public string Rating { get; set; } = string.Empty;

        [JsonProperty("captain")]
        public bool? Captain { get; set; }
    }
}