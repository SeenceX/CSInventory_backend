using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
{

    /*

    [Table("items_collection")]
    public class ItemCollection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdCollection { get; set; }
        [Required]
        public string NameCollection { get; set; }

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

            

            //добавление начальных данных для таблицы ItemsCollections
            modelBuilder.Entity<ItemCollection>().HasData(
                new ItemCollection { IdCollection = 1, NameCollection = "-"},
                new ItemCollection { IdCollection = 2, NameCollection = "Коллекция «eSports 2013»" },
                new ItemCollection { IdCollection = 3, NameCollection = "Коллекция «Vertigo»" },
                new ItemCollection { IdCollection = 4, NameCollection = "Коллекция «Militia»" },
                new ItemCollection { IdCollection = 5, NameCollection = "Коллекция «Arms Deal»" },
                new ItemCollection { IdCollection = 6, NameCollection = "Коллекция «Inferno»" },
                new ItemCollection { IdCollection = 7, NameCollection = "Коллекция «Aztec»" },
                new ItemCollection { IdCollection = 8, NameCollection = "Коллекция «Nuke»" },
                new ItemCollection { IdCollection = 9, NameCollection = "Коллекция «Office»" },
                new ItemCollection { IdCollection = 10, NameCollection = "Коллекция «Dust»" },
                new ItemCollection { IdCollection = 11, NameCollection = "Коллекция «Assault»" },
                new ItemCollection { IdCollection = 12, NameCollection = "Коллекция «Браво»" },
                new ItemCollection { IdCollection = 13, NameCollection = "Коллекция «Альфа»" },
                new ItemCollection { IdCollection = 14, NameCollection = "Коллекция «Arms Deal 2»" },
                new ItemCollection { IdCollection = 15, NameCollection = "Коллекция «Train»" },
                new ItemCollection { IdCollection = 16, NameCollection = "Коллекция «Lake»" },
                new ItemCollection { IdCollection = 17, NameCollection = "Коллекция «Dust 2»" },
                new ItemCollection { IdCollection = 18, NameCollection = "Коллекция «Mirage»" },
                new ItemCollection { IdCollection = 19, NameCollection = "Коллекция «Italy»" },
                new ItemCollection { IdCollection = 20, NameCollection = "Коллекция «Winter Offensive»" },
                new ItemCollection { IdCollection = 21, NameCollection = "Коллекция «eSports 2013 Winter»" },
                new ItemCollection { IdCollection = 22, NameCollection = "Коллекция «Arms Deal 3»" },
                new ItemCollection { IdCollection = 23, NameCollection = "Коллекция «Феникс»" },
                new ItemCollection { IdCollection = 24, NameCollection = "Охотничья коллекция" },
                new ItemCollection { IdCollection = 25, NameCollection = "Коллекция «Bank»" },
                new ItemCollection { IdCollection = 26, NameCollection = "Коллекция «Cobblestone»" },
                new ItemCollection { IdCollection = 27, NameCollection = "Коллекция «Overpass»" },
                new ItemCollection { IdCollection = 28, NameCollection = "Коллекция «Baggage»" },
                new ItemCollection { IdCollection = 29, NameCollection = "Коллекция «Прорыв»" },
                new ItemCollection { IdCollection = 30, NameCollection = "Коллекция «eSports 2014 Summer»" },
                new ItemCollection { IdCollection = 31, NameCollection = "Коллекция «Cache»" },
                new ItemCollection { IdCollection = 32, NameCollection = "Коллекция «Авангард»" },
                new ItemCollection { IdCollection = 33, NameCollection = "Коллекция из хромированного кейса" },
                new ItemCollection { IdCollection = 34, NameCollection = "Коллекция из хромированного кейса #2" },
                new ItemCollection { IdCollection = 35, NameCollection = "Коллекция «Фальшион»" },
                new ItemCollection { IdCollection = 36, NameCollection = "Коллекция «Чик-чик»" },
                new ItemCollection { IdCollection = 37, NameCollection = "Коллекция «Боги и чудовища»" },
                new ItemCollection { IdCollection = 38, NameCollection = "Коллекция «Рассвет»" },
                new ItemCollection { IdCollection = 39, NameCollection = "Коллекция из тёмного кейса" },
                new ItemCollection { IdCollection = 40, NameCollection = "Револьверная коллекция" },
                new ItemCollection { IdCollection = 41, NameCollection = "Коллекция «Дикое пламя»" },
                new ItemCollection { IdCollection = 42, NameCollection = "Коллекция из хромированного кейса #3" },
                new ItemCollection { IdCollection = 43, NameCollection = "Коллекция «Гамма»" },
                new ItemCollection { IdCollection = 44, NameCollection = "Коллекция «Гамма 2»" },
                new ItemCollection { IdCollection = 45, NameCollection = "Перчаточная коллекция" },
                new ItemCollection { IdCollection = 46, NameCollection = "Коллекция «Спектр»" },
                new ItemCollection { IdCollection = 47, NameCollection = "Коллекция «Горизонт»" },
                new ItemCollection { IdCollection = 48, NameCollection = "Коллекция «Inferno 2018»" },
                new ItemCollection { IdCollection = 49, NameCollection = "Коллекция «Nuke 2018»" },
                new ItemCollection { IdCollection = 50, NameCollection = "Коллекция «Запретная зона»" },
                new ItemCollection { IdCollection = 51, NameCollection = "Коллекция «Blacksite»" },
                new ItemCollection { IdCollection = 52, NameCollection = "Коллекция «Решающий момент»" },
                new ItemCollection { IdCollection = 53, NameCollection = "Коллекция «Призма»" },
                new ItemCollection { IdCollection = 54, NameCollection = "Коллекция «Рентген»" },
                new ItemCollection { IdCollection = 55, NameCollection = "Коллекция «CS20»" },
                new ItemCollection { IdCollection = 56, NameCollection = "Коллекция «Расколотая сеть»" },
                new ItemCollection { IdCollection = 57, NameCollection = "Коллекция «Север»" },
                new ItemCollection { IdCollection = 58, NameCollection = "Коллекция «St. Marc»" },
                new ItemCollection { IdCollection = 59, NameCollection = "Коллекция «Canals»" },
                new ItemCollection { IdCollection = 60, NameCollection = "Коллекция «Призма 2»" },
                new ItemCollection { IdCollection = 61, NameCollection = "Коллекция «Разлом»" },
                new ItemCollection { IdCollection = 62, NameCollection = "Коллекция «Хаос»" },
                new ItemCollection { IdCollection = 63, NameCollection = "Коллекция «Ancient»" },
                new ItemCollection { IdCollection = 64, NameCollection = "Коллекция «Контроль»" },
                new ItemCollection { IdCollection = 65, NameCollection = "Коллекция операции «Сломанный клык»" },
                new ItemCollection { IdCollection = 66, NameCollection = "Коллекция «Змеиный укус»" },
                new ItemCollection { IdCollection = 67, NameCollection = "Коллекция операции «Хищные воды»" },
                new ItemCollection { IdCollection = 68, NameCollection = "Коллекция Vertigo 2021" },
                new ItemCollection { IdCollection = 69, NameCollection = "Коллекция Mirage 2021" },
                new ItemCollection { IdCollection = 70, NameCollection = "Коллекция Dust 2 2021" },
                new ItemCollection { IdCollection = 71, NameCollection = "Коллекция Train 2021" },
                new ItemCollection { IdCollection = 72, NameCollection = "Коллекция «Грёзы и кошмары»" },
                new ItemCollection { IdCollection = 73, NameCollection = "The Recoil Collection" },
                new ItemCollection { IdCollection = 74, NameCollection = "The Revolution Collection" },
                new ItemCollection { IdCollection = 75, NameCollection = "The Anubis Collection" }
            );
        }
    }
}
