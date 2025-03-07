using DomainLayer.Aggregate;
using InfrastructureLayer.Models.MatchInformations;

namespace InfrastructureLayer.Mapper
{
    public class MatchInformationsMapper
    {
        public static List<MatchPlayed> MapToMatchPlayedList(Query query)
        {
            var matchPlayedList = new List<MatchPlayed>();
            if (query != null && query.Response.Count > 0)
            {
                foreach (var match in query.Response)
                {
                    matchPlayedList.Add(new MatchPlayed()
                    {
                        Match = new DomainLayer.Entities.Match()
                        {
                            Id = match.Fixture.Id,
                            HomeTeam = new DomainLayer.Entities.Team()
                            {
                                Id = match.Teams.Home.Id,
                                Name = match.Teams.Home.Name
                            },
                            AwayTeam = new DomainLayer.Entities.Team()
                            {
                                Id = match.Teams.Away.Id,
                                Name = match.Teams.Away.Name
                            }
                        },
                        League = new DomainLayer.Entities.League()
                        {

                        },
                        DateAndTime = DateTime.Parse(match.Fixture.Date),
                        HomeScore = match.ScoreBoard.FullTimeScore.Home,
                        AwayScore = match.ScoreBoard.FullTimeScore.Away,
                        Statistics = new MatchStatistics()
                        {
                            HalfTimeScore = new DomainLayer.ValueObject.HalfTimeScore()
                            {
                                Home = match.ScoreBoard.HalfTimeScore.Home,
                                Away = match.ScoreBoard.HalfTimeScore.Away
                            },
                            FullTimeScore = new DomainLayer.ValueObject.FullTimeScore()
                            {
                                Home = match.ScoreBoard.FullTimeScore.Home,
                                Away = match.ScoreBoard.FullTimeScore.Away
                            },
                            ExtraTimeScore = new DomainLayer.ValueObject.ExtraTimeScore()
                            {
                                Home = match.ScoreBoard.ExtraTimeScore.Home,
                                Away = match.ScoreBoard.ExtraTimeScore.Away
                            },
                            PenaltyScore = new DomainLayer.ValueObject.PenaltyScore()
                            {
                                Home = match.ScoreBoard.PenaltyScore.Home,
                                Away = match.ScoreBoard.PenaltyScore.Away
                            }
                        }
                    });
                }
            }
            return matchPlayedList;

        }

        public static List<MatchToPlay> MapToMatchToPlayList(Query query)
        {
            var matchToPlayList = new List<MatchToPlay>();
            if (query != null && query.Response.Count > 0)
            {
                foreach (var match in query.Response)
                {
                    matchToPlayList.Add(new MatchToPlay()
                    {
                        Match = new DomainLayer.Entities.Match()
                        {
                            Id = match.Fixture.Id,
                            HomeTeam = new DomainLayer.Entities.Team()
                            {
                                Id = match.Teams.Home.Id,
                                Name = match.Teams.Home.Name
                            },
                            AwayTeam = new DomainLayer.Entities.Team()
                            {
                                Id = match.Teams.Away.Id,
                                Name = match.Teams.Away.Name
                            }
                        },
                        League = new DomainLayer.Entities.League()
                        {

                        },
                        DateAndTime = DateTime.Parse(match.Fixture.Date),
                       
                    });
                }
            }
            return matchToPlayList;
        }
    }
}