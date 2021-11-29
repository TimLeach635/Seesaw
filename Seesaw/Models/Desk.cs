using NetTopologySuite.Geometries;
using System.Collections.Generic;

namespace Seesaw.Models
{
    public class Desk
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public Polygon BoundingBox { get; set; }
        
        //FOREIGN KEYS
        public Unit ContainingUnit { get; set; }
        public List<DeskAttribute> Attributes { get; set; }
        public List<TeamReservation> TeamReservations { get; set; }
        public List<DeskBooking> Bookings { get; set; }
    }
}