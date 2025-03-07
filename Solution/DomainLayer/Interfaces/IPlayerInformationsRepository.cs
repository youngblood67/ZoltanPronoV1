using DomainLayer.Aggregate;

namespace DomainLayer.Repositories
{
    public interface IPlayerInformationsRepository
    {
        public PlayerInformations?  GetPlayerInformationsByPlayerIdTeamIdAndSeasonId(int playerId, int teamId, int seasonId);

    }
}
