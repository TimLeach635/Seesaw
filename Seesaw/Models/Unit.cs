using System.Collections.Generic;

namespace Seesaw.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public Office ContainingOffice { get; set; }
        public List<Desk> Desks { get; set; }
        public List<MeetingRoom> MeetingRooms { get; set; }
        public string DisplayName { get; set; }
        public byte[] FloorPlanImage { get; set; }
    }
}