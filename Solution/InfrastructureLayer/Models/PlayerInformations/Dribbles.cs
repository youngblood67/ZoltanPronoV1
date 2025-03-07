using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Dribbles
    {
        [JsonProperty("attempts")]
        public int? Attempts { get; set; }

        [JsonProperty("success")]
        public int? Success { get; set; }

        [JsonProperty("past")]
        public int? Past { get; set; }

    }
}