using System;
using System.ComponentModel.DataAnnotations;


namespace Seesaw.Models
{
    public class MeetingRoomBooking
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int MeetingRoomID { get; set; }
        public int BookerId { get; set; }
        public int OccupierId { get; set; }
        public DateTime  BookedFrom { get; set; }
        public DateTime  BookedTo { get; set; }
        public string DisplayName { get; set; }
        
        
        
    }
}