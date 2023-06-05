using Microsoft.EntityFrameworkCore;

namespace CSInventoryDatabase.Database
{
    public class InventoryContext : DbContext
    {
        public DbSet<Inventory> Inventories { get; set; }
        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options) { Database.EnsureCreated(); }
    }
}

