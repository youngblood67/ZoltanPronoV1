using DomainLayer.ValueObject;

namespace DomainLayer.Aggregate
{
    public class PlayerStatistics
    {
        public PlayerStatistics()
        {
            Cards = new Cards();
            Dribbles = new Dribbles();
            Duels = new Duels();
            Fouls = new Fouls();
            Games = new Games();
            Goals = new Goals();
            Passes = new Passes();
            Penalty = new Penalty();
            Shots = new Shots();
            Substitutes = new Substitutes();
            Tackles = new Tackles();
        }
        public Cards Cards { get; set; }
        public Dribbles Dribbles { get; set; }
        public Duels Duels { get; set; }
        public Fouls Fouls { get; set; }
        public Games Games { get; set; }
        public Goals Goals { get; set; }
        public Passes Passes { get; set; }
        public Penalty Penalty { get; set; }
        public Shots Shots { get; set; }
        public Substitutes Substitutes { get; set; }
        public Tackles Tackles { get; set; }

    }
}