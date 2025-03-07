using ApplicationLayer.Interfaces;
using DomainLayer.Aggregate;
using DomainLayer.Repositories;

namespace ApplicationLayer.UseCases
{
    public class MatchInformationsService : IMatchInformationsService
    {
        private readonly IMatchRepository _matchRepository;

        public MatchInformationsService(IMatchRepository matchRepository)
        {
            _matchRepository = matchRepository;
        }

        public List<MatchPlayed> GetLastMatchesByTeamId(int nbLast, int teamId)
        {
            return _matchRepository.GetLastMatchesByTeamId(nbLast, teamId);
        }

    }
}
