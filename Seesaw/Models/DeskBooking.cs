using System;

namespace Seesaw.Models
{
    public class DeskBooking
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public DateTime Created { get; set; }
        public DateTime BookedFrom { get; set; }
        public DateTime BookedUntil { get; set; }
        public string DisplayName { get; set; }
        
        //FOREIGN KEYS
        public Desk BookedDesk { get; set; }
        public User Booker { get; set; }
        public User Occupier { get; set; }
    }
}