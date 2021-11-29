using Microsoft.EntityFrameworkCore;
using Seesaw.Models;

namespace Seesaw
{
    public class SeesawDbContext : DbContext
    {
        public DbSet<Office> Offices { get; set; }
        public DbSet<MeetingRoom> MeetingRooms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseNpgsql(@"User ID=seesaw;Password=seesaw;Host=localhost;Port=5432;Database=Seesaw-Dev;", x=> x.UseNetTopologySuite());
        }
    }
}