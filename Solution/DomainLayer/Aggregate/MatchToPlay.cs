using DomainLayer.Entities;

namespace DomainLayer.Aggregate
{
    public class MatchToPlay : MatchInformations
    {
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine +
                "Saison " + League.Season + " - " + League.Country + " - " + League.Name +
                Environment.NewLine + Match.HomeTeam.Name + " : - "
                + Environment.NewLine + Match.AwayTeam.Name + " : - "
                + Environment.NewLine + "En attente : le match sera joué le  " + DateAndTime;
        }
    }
}
