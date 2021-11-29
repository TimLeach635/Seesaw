using System;
using System.ComponentModel.DataAnnotations;


namespace Seesaw.Models
{
    public class MeetingRoomBooking
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public DateTime Created { get; set; }
        public DateTime BookedFrom { get; set; }
        public DateTime BookedUntil { get; set; }
        public string DisplayName { get; set; }
        
        //FOREIGN KEYS
        public MeetingRoom BookedRoom { get; set; }
        public User Booker { get; set; }
        public User Occupier { get; set; }
        
        
        
    }
}