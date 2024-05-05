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

 

        public DbSet<Taxi> Taxis { get; set; } //el nombre de esta propiedad será el que tenga la tabla generada en la BD
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Taxi>().ToTable("Taxi");
            modelBuilder.Entity<Trajectory>.ToTable("Trajectory");
        }


    }
}

