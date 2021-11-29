using System.Collections.Generic;

namespace Seesaw.Models
{
    public class DeskAttribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Desk> QualifyingDesks { get; set; }
    }
}