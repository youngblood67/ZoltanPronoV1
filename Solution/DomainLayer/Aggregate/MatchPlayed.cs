using DomainLayer.Entities;

namespace DomainLayer.Aggregate
{
    public class MatchPlayed : MatchInformations
    {
        public int? HomeScore { get; set; }
        public int? AwayScore { get; set; }
        public MatchStatistics Statistics { get; set; } = new MatchStatistics();    
   

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Saison " + League.Season + " - " + League.Country + " - " + League.Name +
                Environment.NewLine + Match.HomeTeam.Name + " : " + HomeScore
                + Environment.NewLine + Match.AwayTeam.Name + " : " + AwayScore
                + Environment.NewLine;
        }

    }
}
