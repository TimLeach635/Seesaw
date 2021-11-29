using System;
using System.Collections.Generic;

namespace Seesaw.Models
{
    public class TeamReservation
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public DateTime Created { get; set; }
        public DateTime ReservedFrom { get; set; }
        public DateTime ReservedUntil { get; set; }
        public string TeamName { get; set; }
        
        //FOREIGN KEYS
        public User Creator { get; set; }
        public List<Desk> ReservedDesks { get; set; }
        
    }
}