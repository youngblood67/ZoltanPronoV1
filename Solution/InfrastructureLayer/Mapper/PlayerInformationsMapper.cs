using DomainLayer.Aggregate;
using InfrastructureLayer.Models.PlayerInformations;

namespace InfrastructureLayer.Mapper
{
    public class PlayerInformationsMapper
    {
        public static PlayerInformations? MapToPlayerInformations(Query query)
        {
            if (query.Response.Count > 0)
            {
                return new PlayerInformations()
                {
                    Player = new DomainLayer.Entities.Player
                    {

                        Id = query.Response[0].Player.Id,
                        Age = query.Response[0].Player.Age,
                        FirstName = query.Response[0].Player.FirstName,
                        LastName = query.Response[0].Player.LastName,
                        Height = query.Response[0].Player.Height,
                        Weight = query.Response[0].Player.Weight,
                        Nationality = query.Response[0].Player.Nationality,
                        Injured = query.Response[0].Player.Injured
                    },
                    Statistics = new DomainLayer.Aggregate.PlayerStatistics()
                    {
                        Cards = new DomainLayer.ValueObject.Cards()
                        {
                            Red = query.Response[0].Statistics[0].Cards.Red,
                            Yellow = query.Response[0].Statistics[0].Cards.Yellow,
                            YellowRed = query.Response[0].Statistics[0].Cards.YellowRed
                        },
                        Goals = new DomainLayer.ValueObject.Goals()
                        {
                            Assists = query.Response[0].Statistics[0].Goals.Assists,
                            Conceded = query.Response[0].Statistics[0].Goals.Conceded,
                            Saves = query.Response[0].Statistics[0].Goals.Saves,
                            Total = query.Response[0].Statistics[0].Goals.Total
                        },
                        Games = new DomainLayer.ValueObject.Games()
                        {
                            Appearences = query.Response[0].Statistics[0].Games.Appearances,
                            LineUps = query.Response[0].Statistics[0].Games.Lineups,
                            MinutesPlayed = query.Response[0].Statistics[0].Games.Minutes,
                            Position = query.Response[0].Statistics[0].Games.Position,
                            Rating = query.Response[0].Statistics[0].Games.Rating,
                            IsCaptain = query.Response[0].Statistics[0].Games.Captain
                        },
                        Fouls = new DomainLayer.ValueObject.Fouls()
                        {
                            Commited = query.Response[0].Statistics[0].Fouls.Committed,
                            Drawn = query.Response[0].Statistics[0].Fouls.Drawn
                        },
                        Passes = new DomainLayer.ValueObject.Passes()
                        {
                            Accuracy = query.Response[0].Statistics[0].Passes.Accuracy,
                            Key = query.Response[0].Statistics[0].Passes.Key,
                            Total = query.Response[0].Statistics[0].Passes.Total
                        },
                        Penalty = new DomainLayer.ValueObject.Penalty()
                        {
                            Commited = query.Response[0].Statistics[0].Penalty.Commited,
                            Missed = query.Response[0].Statistics[0].Penalty.Missed,
                            Saved = query.Response[0].Statistics[0].Penalty.Saved,
                            Scored = query.Response[0].Statistics[0].Penalty.Scored,
                            Won = query.Response[0].Statistics[0].Penalty.Won
                        },
                        Shots = new DomainLayer.ValueObject.Shots()
                        {
                            On = query.Response[0].Statistics[0].Shots.On,
                            Total = query.Response[0].Statistics[0].Shots.Total
                        },
                        Substitutes = new DomainLayer.ValueObject.Substitutes()
                        {
                            Bench = query.Response[0].Statistics[0].Substitutes.Bench,
                            In = query.Response[0].Statistics[0].Substitutes.In,
                            Out = query.Response[0].Statistics[0].Substitutes.Out
                        },
                        Tackles = new DomainLayer.ValueObject.Tackles()
                        {
                            Blocks = query.Response[0].Statistics[0].Tackles.Blocks,
                            Interceptions = query.Response[0].Statistics[0].Tackles.Interceptions,
                            Total = query.Response[0].Statistics[0].Tackles.Total
                        },
                        Dribbles = new DomainLayer.ValueObject.Dribbles()
                        {
                            Attempts = query.Response[0].Statistics[0].Dribbles.Attempts,
                            Past = query.Response[0].Statistics[0].Dribbles.Past,
                            Success = query.Response[0].Statistics[0].Dribbles.Success
                        },
                        Duels = new DomainLayer.ValueObject.Duels()
                        {
                            Total = query.Response[0].Statistics[0].Duels.Total,
                            Won = query.Response[0].Statistics[0].Duels.Won
                        }
                    }
                };
            }
            else
            {
                return null;
            }

        }
    }
}
