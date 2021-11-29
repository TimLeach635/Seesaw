using System.Collections.Generic;

namespace Seesaw.Models
{
    public class Office
    {
        //PRIMARY KEY
        public int Id { get; set; }
        
        public string DisplayName { get; set; }
        
        //FOREIGN KEYS
        public List<Unit> Units { get; set; }
        public List<User> DefaultOccupiers { get; set; }
    }
}