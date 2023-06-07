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

            

            //добавление начальных данных для таблицы ItemsType
            modelBuilder.Entity<ItemType>().HasData(
                new ItemType { IdType = 1, NameType = "Пистолет" },
                new ItemType { IdType = 2, NameType = "Пистолет-пулемёт" },
                new ItemType { IdType = 3, NameType = "Штурмовая винтовка" },
                new ItemType { IdType = 4, NameType = "Снайперская винтовка" },
                new ItemType { IdType = 5, NameType = "Дробовик" },
                new ItemType { IdType = 6, NameType = "Нож" },
                new ItemType { IdType = 7, NameType = "Перчатки" },
                new ItemType { IdType = 8, NameType = "Другое" }
            );

            
        }
    }
}
