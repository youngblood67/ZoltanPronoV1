using DomainLayer.Entities;

namespace DomainLayer.Aggregate
{
    public class PlayerInformations 
    {
        public Player Player { get; set; } = new Player(); 
       
        public PlayerStatistics Statistics { get; set; } =  new PlayerStatistics();
     
    }
}
