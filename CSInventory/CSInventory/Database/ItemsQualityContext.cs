using Microsoft.EntityFrameworkCore;

namespace CSInventoryDatabase.Database
{
    public class ItemsQualityContext: DbContext
    {
        public DbSet<ItemsQuality> ItemsQualities { get; set; }
        public ItemsQualityContext(DbContextOptions<ItemsQualityContext> options) : base(options) { Database.EnsureCreated(); }
    }
}