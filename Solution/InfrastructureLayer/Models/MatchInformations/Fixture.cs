using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class Fixture
    {

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("referee")]
        public string Referee{ get; set; } = string.Empty;

        [JsonProperty("date")]
        public string Date { get; set; } = string.Empty;
    }
}