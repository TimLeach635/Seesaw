using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace Seesaw.Models
{
    public class MeetingRoom
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public string DisplayName { get; set; }
        public Polygon BoundingBox { get; set; }
        public int Capacity { get; set; }

        //FOREIGN KEYS
        public Unit ContainingUnit { get; set; }
        public List<MeetingRoomAttribute> Attributes { get; set; }
        public List<MeetingRoomBooking> Bookings { get; set; }
    }
}