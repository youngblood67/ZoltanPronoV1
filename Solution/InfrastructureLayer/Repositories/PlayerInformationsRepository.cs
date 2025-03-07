using DomainLayer.Aggregate;
using DomainLayer.Repositories;
using InfrastructureLayer.Mapper;
using InfrastructureLayer.Models.PlayerInformations;
using Newtonsoft.Json;

namespace InfrastructureLayer.Repositories
{
    public class PlayerInformationsRepository : IPlayerInformationsRepository
    {
        private const string ApiKey = "018c7ba508536c2b310be5eabf523dae";
        private const string ApiBaseUrl = "https://v3.football.api-sports.io";

        public PlayerInformations? GetPlayerInformationsByPlayerIdTeamIdAndSeasonId(int playerId, int teamId, int seasonId)
        {
            string endpoint = $"{ApiBaseUrl}/players?id={playerId}&team={teamId}&season={seasonId}";
            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
                request.Headers.Add("x-rapidapi-host", "v3.football.api-sports.io");
                request.Headers.Add("x-rapidapi-key", ApiKey);

                var response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var query = JsonConvert.DeserializeObject<Query>(content);

                    var playerInformations = PlayerInformationsMapper.MapToPlayerInformations(query);

                    return playerInformations;
                }
                else
                {
                    // Gérer les erreurs de la requête HTTP
                    throw new Exception($"Erreur de requête HTTP : {response.StatusCode}");
                }
            }
        }
       
    }
}
