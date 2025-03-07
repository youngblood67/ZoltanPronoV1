using Newtonsoft.Json;

namespace InfrastructureLayer.Models.MatchInformations
{
    public class Teams
    {
        [JsonProperty("home")]
        public HomeTeam Home { get; set; }= new HomeTeam(); 

        [JsonProperty("away")]
        public AwayTeam Away { get; set; }  = new AwayTeam();
    }
}