using DomainLayer.Entities;

namespace DomainLayer.Aggregate
{
    public abstract class MatchInformations
    {
        public DateTime DateAndTime { get; set; } = new DateTime();
        public League League { get; set; } = new League();
        public Match Match { get; set; } = new Match();

    }
}
