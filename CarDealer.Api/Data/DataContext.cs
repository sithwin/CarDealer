using cardealer.api.Models;
using Microsoft.EntityFrameworkCore;

namespace cardealer.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Vehicle> Vehicles { get; set; }
    }
}