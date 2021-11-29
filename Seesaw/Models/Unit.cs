using System.Collections.Generic;

namespace Seesaw.Models
{
    public class Unit
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public string DisplayName { get; set; }
        public byte[] FloorPlanImage { get; set; }
        
        //FOREIGN KEYS
        public Office ContainingOffice { get; set; }
        public List<Desk> Desks { get; set; }
        public List<MeetingRoom> MeetingRooms { get; set; }
    }
}