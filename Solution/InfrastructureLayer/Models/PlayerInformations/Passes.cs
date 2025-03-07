using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Passes
    {
        [JsonProperty("total")]
        public int? Total { get; set; }

        [JsonProperty("key")]
        public int? Key { get; set; }

        [JsonProperty("accuracy")]
        public int? Accuracy { get; set; }
    }
}