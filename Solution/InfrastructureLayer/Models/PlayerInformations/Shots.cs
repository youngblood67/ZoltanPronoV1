using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Shots
    {
        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("on")]
        public int? On { get; set; }
    }
}