using Microsoft.EntityFrameworkCore;

namespace StoreApp.EntityFramework
{
    public class StoreDbContextFactory
    {
        private readonly string _ConnectionString;

        public StoreDbContextFactory(string ConnectionString)
        {
            _ConnectionString = ConnectionString;
        }

        public StoreDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<StoreDbContext>();
            options.UseSqlite(_ConnectionString);
            return new StoreDbContext(options.Options);
        }
    }
}