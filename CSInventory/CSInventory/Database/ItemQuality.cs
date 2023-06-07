using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
{

    public class SiteContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Inventory> Inventory => Set<Inventory>();
        public DbSet<AllItems> AllItems => Set<AllItems>();
        public DbSet<ItemQuality> ItemsQuality => Set<ItemQuality>();
        public DbSet<ItemRare> itemsRares => Set<ItemRare>();
        public DbSet<ItemType> ItemsType => Set<ItemType>();
        public DbSet<ItemCollection> ItemsCollections => Set<ItemCollection>();


        public SiteContext(DbContextOptions<SiteContext> options) : base(options) { Database.EnsureCreated(); }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            

            //добавление начальных данных для таблицы ItemsQuality
            modelBuilder.Entity<ItemQuality>().HasData(
                new ItemQuality { IdQuality = 1, NameQuality = "-" },
                new ItemQuality { IdQuality = 2, NameQuality = "Закаленное в боях"},
                new ItemQuality { IdQuality = 3, NameQuality = "Поношенное" },
                new ItemQuality { IdQuality = 4, NameQuality = "После полевых испытаний" },
                new ItemQuality { IdQuality = 5, NameQuality = "Немного поношенное" },
                new ItemQuality { IdQuality = 6, NameQuality = "Прямо с завода" }
            );

           
        }
    }
}
