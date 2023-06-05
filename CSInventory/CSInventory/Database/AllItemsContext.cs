using Microsoft.EntityFrameworkCore;

namespace CSInventoryDatabase.Database
{
    public class AllItemsContext : DbContext
    {
        public DbSet<AllItems> AllItems { get; set; }
        public AllItemsContext(DbContextOptions<AllItemsContext> options) : base(options) { Database.EnsureCreated(); }
    }
}
