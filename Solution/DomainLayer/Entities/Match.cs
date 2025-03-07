namespace DomainLayer.Entities
{
    public class Match : Entity
    {
        public Team HomeTeam { get; set; } = new Team();
        public Team AwayTeam { get; set; } = new Team();
    }
}
