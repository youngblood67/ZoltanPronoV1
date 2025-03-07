using Newtonsoft.Json;

namespace InfrastructureLayer.Models.PlayerInformations
{
    public class Player
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("firstname")]
        public string FirstName { get; set; } = string.Empty;

        [JsonProperty("lastname")]
        public string LastName { get; set; } = string.Empty;

        [JsonProperty("age")]
        public int? Age { get; set; }

        [JsonProperty("nationality")]
        public string Nationality { get; set; } = string.Empty;

        [JsonProperty("height")]
        public string Height { get; set; } = string.Empty;

        [JsonProperty("weight")]
        public string Weight { get; set; } = string.Empty;

        [JsonProperty("injured")]
        public bool? Injured { get; set; } 

    }
}