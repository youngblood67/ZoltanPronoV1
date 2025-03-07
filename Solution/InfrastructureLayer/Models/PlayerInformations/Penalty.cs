using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Penalty
    {
        [JsonProperty("won")]
        public int? Won { get; set; }
        [JsonProperty("commited")]
        public int? Commited { get; set; }

        [JsonProperty("scored")]
        public int? Scored { get; set; }

        [JsonProperty("missed")]
        public int? Missed { get; set; }

        [JsonProperty("saved")]
        public int? Saved { get; set; }

    }
}