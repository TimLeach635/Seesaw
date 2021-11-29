using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace Seesaw.Models
{
    public class Desk
    {
        public int Id { get; set; }
        public Unit ContainingUnit { get; set; }
        public Polygon BoundingBox { get; set; }
        //public List<DeskAttributes> Attributes { get; set; }
        //public List<TeamReservations> TeamReservations { get; set; }
        //public List<Bookings> Bookings { get; set; }
    }
}