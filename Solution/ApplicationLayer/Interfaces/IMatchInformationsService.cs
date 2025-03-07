using DomainLayer.Aggregate;

namespace ApplicationLayer.Interfaces
{
    public interface IMatchInformationsService
    {
        List<MatchPlayed> GetLastMatchesByTeamId(int nbLast, int teamId);
    }
}
