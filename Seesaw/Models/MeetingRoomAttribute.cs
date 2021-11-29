using System.Collections.Generic;

namespace Seesaw.Models
{
    public class MeetingRoomAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<MeetingRoom> CompliantRooms { get; set; }
    }
}