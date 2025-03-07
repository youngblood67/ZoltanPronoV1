using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Cards
    {
        [JsonProperty("yellow")]
        public int? Yellow { get; set; }

        [JsonProperty("yellowred")]
        public int? YellowRed { get; set; }

        [JsonProperty("red")]
        public int? Red { get; set; }

    }
}