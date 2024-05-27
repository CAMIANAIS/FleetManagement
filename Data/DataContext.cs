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
        public DbSet<Trajectory> trajectories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taxi>().ToTable("taxis");
            modelBuilder.Entity<Taxi>().HasKey(t => t.id);
   

            modelBuilder.Entity<Trajectory>().ToTable("trajectories");
            modelBuilder.Entity<Trajectory>().HasKey(tr => tr.idtrajectories);
           

            modelBuilder.Entity<Trajectory>()
                .HasOne(tr => tr.Taxi)
                .WithMany(t => t.Trajectories)
                .HasForeignKey(tr => tr.taxiid);

            base.OnModelCreating(modelBuilder);
        }
    }
}

