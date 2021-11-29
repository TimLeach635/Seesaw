using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace Seesaw.Models
{
    public class MeetingRoom
    {
        public int Id { get; set; }
        public Unit ContainingUnit { get; set; }
        public string DisplayName { get; set; }
        public Polygon BoundingBox { get; set; }
        public int Capacity { get; set; }
        public List<MeetingRoomAttribute> Attributes { get; set; }
    }
}