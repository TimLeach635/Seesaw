using System.Collections.Generic;

namespace Seesaw.Models
{
    public class Office
    {
        public int Id { get; set; }
        public List<Unit> Units { get; set; }
        public string DisplayName { get; set; }
    }
}