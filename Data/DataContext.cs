using FleetManagement.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Taxi> Taxis { get; set; }
        public DbSet<Trajectory> Trajectories { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taxi>().ToTable("Taxi");
            modelBuilder.Entity<Trajectory>().ToTable("Trajectories"); 
        }
    }
}
