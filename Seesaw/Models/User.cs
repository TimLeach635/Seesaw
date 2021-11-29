using Npgsql.TypeHandlers;

namespace Seesaw.Models
{
    public class User
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public bool IsAdmin { get; set; }
    }
}