using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Response
    {
        [JsonProperty("player")]
        public Player? Player { get; set; } = new Player(); 

        [JsonProperty("statistics")]
        public List<PlayerStatistics>? Statistics { get; set; } = new List<PlayerStatistics>(); 

    }
}
