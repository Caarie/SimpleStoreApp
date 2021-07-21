using Microsoft.EntityFrameworkCore;
using StoreApp.Model.Models;

namespace StoreApp.EntityFramework
{
    public class StoreDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Provider> Providers { get; set; }

        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}