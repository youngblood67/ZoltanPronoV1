namespace DomainLayer.Entities
{
    public class Player : Entity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int? Age { get; set; }

        public string Nationality { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public bool? Injured { get; set; } = false;
        public int? HeightInCm
        {
            get
            {
                if (Height == null || Height == string.Empty)
                {
                    return null;
                }
                else
                    return int.Parse(Height.Split(' ')[0]);
            }
        }

        public int? WeightInKg
        {
            get
            {
                if (Weight == null || Weight == string.Empty)
                {
                    return null;
                }
                else
                    return int.Parse(Weight.Split(' ')[0]);
            }
        }
    }
}
