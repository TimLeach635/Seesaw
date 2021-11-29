using Microsoft.EntityFrameworkCore;
using Seesaw.Models;

namespace Seesaw
{
    public class SeesawDbContext : DbContext
    {
        public DbSet<Office> Offices { get; set; }
        public DbSet<MeetingRoom> MeetingRooms { get; set; }
        public DbSet<MeetingRoomAttribute> MeetingRoomAttributes { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Desk> Desks { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamReservation> TeamReservations { get; set; } 
        public DbSet<DeskBooking> DeskBookings { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseNpgsql(@"User ID=seesaw;Password=seesaw;Host=localhost;Port=5432;Database=Seesaw-Dev;", x=> x.UseNetTopologySuite());
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.HasPostgresExtension("postgis");
        }
    }
}