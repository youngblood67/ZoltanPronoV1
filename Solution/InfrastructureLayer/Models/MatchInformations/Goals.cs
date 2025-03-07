using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class Goals
    {
        [JsonProperty("home")]
        public int? Home { get; set; }

        [JsonProperty("away")]
        public int? Away { get; set; }
    }
}