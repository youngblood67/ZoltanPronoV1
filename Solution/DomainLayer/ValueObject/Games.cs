namespace DomainLayer.ValueObject
{
    public class Games
    {
        public int? Appearences { get; set; }
        public int? LineUps { get; set; }
        public int? MinutesPlayed { get; set; }
        public string Position { get; set; } = string.Empty;
        public string Rating { get; set; } = string.Empty;
        public bool? IsCaptain { get; set; } = false;

        public decimal RatingInDecimal
        {
            get
            {
                if (Rating == string.Empty)
                {
                    return 0;
                }
                else
                {
                    return decimal.Parse(Rating);
                }
            }
        }
    }
}