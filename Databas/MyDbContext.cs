using MetroMetricsApp.Modeller;
using Microsoft.EntityFrameworkCore;

namespace MetroMetricsApp.Databas
{
    public class MyDbContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>()
            .Property(c => c.Latitude)
            .HasColumnType("decimal(10, 7)"); // Adjust precision and scale as needed

            modelBuilder.Entity<City>()
            .Property(c => c.Longitude)
            .HasColumnType("decimal(10, 7)"); // Adjust precision and scale as needed

        }

        // OnConfiguring: vi till vår connection string. 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            // Kommer skapas en databas på servern med detta namnet.
            optionsBuilder.UseSqlServer("Server=USER-PC\\SQLEXPRESS;Database=MetroMetricsDataBase;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True;MultipleActiveResultSets=True;");
        }
    }
}