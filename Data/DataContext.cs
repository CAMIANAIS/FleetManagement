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

        public DbSet<Taxi> taxis { get; set; }
        public DbSet<Trajectory> Trajectories { get; set; } 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taxi>().ToTable("taxis");
            modelBuilder.Entity<Trajectory>().ToTable("trajectories");
            modelBuilder.Entity<Trajectory>()
    .HasOne<Taxi>()
    .WithMany() // Asumiendo una relación uno a muchos
    .HasForeignKey(t => t.taxi_id);
        }
    }
}
