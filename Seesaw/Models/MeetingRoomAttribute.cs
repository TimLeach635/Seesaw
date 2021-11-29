using System.Collections.Generic;

namespace Seesaw.Models
{
    public class MeetingRoomAttribute
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        //FOREIGN KEYS
        public List<MeetingRoom> QualifyingRooms { get; set; }
    }
}