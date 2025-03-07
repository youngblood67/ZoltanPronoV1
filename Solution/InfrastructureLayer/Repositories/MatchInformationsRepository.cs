using DomainLayer.Aggregate;
using DomainLayer.Repositories;
using InfrastructureLayer.Mapper;
using InfrastructureLayer.Models;
using InfrastructureLayer.Models.MatchInformations;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace InfrastructureLayer.Repositories
{
    public class MatchInformationsRepository : IMatchRepository
    {
        private readonly string _apiKey;
        private readonly string _apiBaseUrl;

        public MatchInformationsRepository(IOptions<ApiSettings> apiSettings)
        {
            _apiKey = apiSettings.Value.ApiKey;
            _apiBaseUrl = apiSettings.Value.ApiBaseUrl;
        }

        public List<MatchPlayed> GetLastMatchesByLeagueId(int nbLast, int leagueId)
        {
            string endpoint = $"{_apiBaseUrl}/fixtures?league={leagueId}&last={nbLast}";

            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
                request.Headers.Add("x-rapidapi-host", "v3.football.api-sports.io");
                request.Headers.Add("x-rapidapi-key", _apiKey);

                var response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var query = JsonConvert.DeserializeObject<Query>(content);

                    var matchesInformations = MatchInformationsMapper.MapToMatchPlayedList(query);

                    return matchesInformations;
                }
                else
                {
                    throw new Exception($"Erreur de requête HTTP : {response.StatusCode}");
                }
            }
        }
        public List<MatchToPlay> GetNextMatchesByLeagueId(int nbNext, int leagueId)
        {
            string endpoint = $"{_apiBaseUrl}/fixtures?league={leagueId}&next={nbNext}";

            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
                request.Headers.Add("x-rapidapi-host", "v3.football.api-sports.io");
                request.Headers.Add("x-rapidapi-key", _apiKey);

                var response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var query = JsonConvert.DeserializeObject<Query>(content);

                    var matchesInformations = MatchInformationsMapper.MapToMatchToPlayList(query);

                    return matchesInformations;
                }
                else
                {
                    throw new Exception($"Erreur de requête HTTP : {response.StatusCode}");
                }
            }
        }
        public List<MatchPlayed> GetLastMatchesByTeamId(int nbLast, int teamId)
        {
            string endpoint = $"{_apiBaseUrl}/fixtures?team={teamId}&last={nbLast}";

            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
                request.Headers.Add("x-rapidapi-host", "v3.football.api-sports.io");
                request.Headers.Add("x-rapidapi-key", _apiKey);

                var response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var query = JsonConvert.DeserializeObject<Query>(content);

                    var matchesInformations = MatchInformationsMapper.MapToMatchPlayedList(query);

                    return matchesInformations;
                }
                else
                {
                    throw new Exception($"Erreur de requête HTTP : {response.StatusCode}");
                }
            }
        }
        public List<MatchToPlay> GetNextMatchesByTeamId(int nbNext, int teamId)
        {
            string endpoint = $"{_apiBaseUrl}/fixtures?team={teamId}&next={nbNext}&";

            using (HttpClient client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, endpoint);
                request.Headers.Add("x-rapidapi-host", "v3.football.api-sports.io");
                request.Headers.Add("x-rapidapi-key", _apiKey);

                var response = client.Send(request);

                if (response.IsSuccessStatusCode)
                {
                    var content = response.Content.ReadAsStringAsync().Result;
                    var query = JsonConvert.DeserializeObject<Query>(content);

                    var matchesInformations = MatchInformationsMapper.MapToMatchToPlayList(query);

                    return matchesInformations;
                }
                else
                {
                    throw new Exception($"Erreur de requête HTTP : {response.StatusCode}");
                }
            }
        }


    }
}
