using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Fouls
    {
        [JsonProperty("drawn")]
        public int? Drawn { get; set; }

        [JsonProperty("committed")]
        public int? Committed { get; set; }

    }
}