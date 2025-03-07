using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class Query
    {
        [JsonProperty("response")]
        public List<Response> Response { get; set; } = new List<Response>();    

    }
}
