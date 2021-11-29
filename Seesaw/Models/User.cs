using System.Collections.Generic;
using Npgsql.TypeHandlers;

namespace Seesaw.Models
{
    public class User
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public string DisplayName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public bool IsAdmin { get; set; }
        public string Email { get; set; }
        
        //FOREIGN KEYS
        public Office DefaultOffice { get; set; }
        public List<TeamReservation> TeamReservations { get; set; }
        public List<MeetingRoomBooking> MeetingRoomBookings { get; set; }
        public List<DeskBooking> DeskBookings { get; set; }
    }
}