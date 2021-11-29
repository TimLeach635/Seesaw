namespace Seesaw.Models
{
    public class Unit
    {
        public int Id { get; set; }
        public Office ContainingOffice { get; set; }
        public string DisplayName { get; set; }
        public byte[] FloorPlanImage { get; set; }
    }
}