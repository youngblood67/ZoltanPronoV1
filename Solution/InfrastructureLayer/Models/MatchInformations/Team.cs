using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class Team
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; } = string.Empty;

    }
}
