using System;

namespace Seesaw.Models
{
    public class DeskBooking
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int BookerId { get; set; }
        public int OccupierId { get; set; } 
    }
}