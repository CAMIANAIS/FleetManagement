using Microsoft.EntityFrameworkCore;

namespace FleetManagement.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = "Host=ep-old-hill-a4d5re0z-pooler.us-east-1.aws.neon.tech;Database=verceldb;Username=default;Password=xCQEL4kMeT1t";
                optionsBuilder.UseNpgsql(connectionString);
            }
        }

        // DbSet properties here
    }
}
