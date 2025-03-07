using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Duels
    {
        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("won")]
        public int? Won { get; set; }

    }
}