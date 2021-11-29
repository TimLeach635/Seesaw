using System;

namespace Seesaw.Models
{
    public class Team
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string DisplayName { get; set; }
        
        public int CreatorId { get; set; }
        
        public DateTime BookedFrom { get; set; }
        public DateTime BookedTo { get; set; }
        
    }
}