using System;

namespace Seesaw.Models
{
    public class DeskBooking
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int BookerId { get; set; }
        public int OccupierId { get; set; }
        public DateTime BookedFrom { get; set; }
        public DateTime BookedTo { get; set; }
        public Desk BookedDesk { get; set; }
        public string DisplayName { get; set; }
    }
}