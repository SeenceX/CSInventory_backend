using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
{

   /*

    [Table("items_rare")]
    public class ItemRare
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdRare { get; set; }
        [Required]
        public string NameRare { get; set; }

    }

    */

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

            

            //добавление начальных данных для таблицы ItemsRare
            modelBuilder.Entity<ItemRare>().HasData(
                new ItemRare { IdRare = 1, NameRare = "Базовый класс" },
                new ItemRare { IdRare = 2, NameRare = "Ширпотреб" },
                new ItemRare { IdRare = 3, NameRare = "Промышленное качество" },
                new ItemRare { IdRare = 4, NameRare = "Армейское качество" },
                new ItemRare { IdRare = 5, NameRare = "Запрещённое" },
                new ItemRare { IdRare = 6, NameRare = "Засекреченное" },
                new ItemRare { IdRare = 7, NameRare = "Тайное" },
                new ItemRare { IdRare = 8, NameRare = "Тайное*" },
                new ItemRare { IdRare = 9, NameRare = "Сувенир" }
                
            );

            
        }
    }
}
