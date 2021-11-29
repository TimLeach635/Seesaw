namespace Seesaw.Models
{
    public class TeamReservation
    {
        public int Id { get; set; }

        public int DeskId {
            get;
            set;
        }
        
        public Desk Desk { get; set; }
        
        public int TeamId { get; set; }
        
        public Team Team { get; set; }
    }
}