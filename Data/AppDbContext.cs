using Microsoft.EntityFrameworkCore;
using TaxiSluzbaBackend.Models;

namespace TaxiSluzbaBackend.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
