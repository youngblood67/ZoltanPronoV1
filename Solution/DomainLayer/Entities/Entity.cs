namespace DomainLayer.Entities
{
    public abstract class Entity
    {
        public int Id { get; set; }

        public Entity()
        {

        }
        public Entity(int id)
        {
            Id = id;
        }
        public override string ToString()
        {
            return GetType().Name + " [Id=" + Id + "]";
        }
    }
}
