using Microsoft.EntityFrameworkCore;
using webapp_travel_agency.Models;

namespace webapp_travel_agency.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Travelpackege> Travelpackeges { set; get; }
        public DbSet<Location> Locations { set; get; }
    }
}
