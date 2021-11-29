using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace Seesaw.Models
{
    public class Desk
    {
        public int Id { get; set; }
        public Unit ContainingUnit { get; set; }
        public Polygon BoundingBox { get; set; }
        public List<DeskAttribute> Attributes { get; set; }
        public List<TeamReservation> TeamReservations { get; set; }
        public List<DeskBooking> Bookings { get; set; }
    }
}