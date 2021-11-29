using Microsoft.EntityFrameworkCore;
using Seesaw.Models;

namespace Seesaw
{
    public class SeesawDbContext : DbContext
    {
        public DbSet<Office> Offices { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { 
            optionsBuilder.UseNpgsql(@"User ID=seesaw;Password=seesaw;Host=localhost;Port=5432;Database=seesaw;");
        }
    }
}