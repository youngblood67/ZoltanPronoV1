using DomainLayer.ValueObject;

namespace DomainLayer.Aggregate
{
    public class MatchStatistics
    {
        public HalfTimeScore HalfTimeScore { get; set; } = new HalfTimeScore();
        public FullTimeScore FullTimeScore { get; set; } = new FullTimeScore();
        public ExtraTimeScore ExtraTimeScore { get; set; } = new ExtraTimeScore();
        public PenaltyScore PenaltyScore { get; set; } = new PenaltyScore();

    }
}