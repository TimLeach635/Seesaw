using System.Collections.Generic;

namespace Seesaw.Models
{
    public class DeskAttribute
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        //FOREIGN KEYS
        public List<Desk> QualifyingDesks { get; set; }
    }
}