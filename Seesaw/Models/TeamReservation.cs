using System;
using System.Collections.Generic;

namespace Seesaw.Models
{
    public class TeamReservation
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string TeamName { get; set; }
        
        public User Creator { get; set; }

        public List<Desk> ReservedDesks { get; set; }

        public DateTime ReservedFrom { get; set; }
        public DateTime ReservedUntil { get; set; }
        
    }
}