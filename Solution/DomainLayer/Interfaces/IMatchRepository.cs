using DomainLayer.Aggregate;

namespace DomainLayer.Repositories
{
    public interface IMatchRepository
    {
        public List<MatchPlayed> GetLastMatchesByLeagueId(int nbLast, int leagueId);
        public List<MatchToPlay> GetNextMatchesByLeagueId(int nbNext, int leagueId);
        public List<MatchPlayed> GetLastMatchesByTeamId(int nbLast, int teamId);
        public List<MatchToPlay> GetNextMatchesByTeamId(int nbNext, int teamId);


    }
}
