using Microsoft.EntityFrameworkCore;
using Soccer.Models;

namespace Soccer.Data
{
    // Define your application's DbContext
    public class ApplicationDbContext : DbContext
    {
        // Constructor that passes options to the base DbContext
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        // Define DbSets for your entities. For example, a Products table:
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }

        // Override OnModelCreating to configure your model (optional)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // You can add custom model configurations here, for example:
            // modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired();
        }
    }
}
