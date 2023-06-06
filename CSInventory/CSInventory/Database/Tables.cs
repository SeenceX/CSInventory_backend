using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
{

    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int UserId { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public DateTime RegistrationDate { get; set; }

        //внешний ключ на таблицу inventory, внутри которой создастся поле UserId связь один ко многиь (1->m)
        public List<Inventory>? Inventories { get; set; }


    }

    [Table("inventory")]
    public class Inventory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int Id { get; set; }
        [Required]
        public AllItems? ItemId { get; set; }
        [Required]
        public int ItemCount { get; set; }
        [Required]
        public float InitialPrice { get; set; }
        public User UserId { get; set; }
    }

    [Table("all_items")]
    public class AllItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ItemId { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public float ItemPrice { get; set; }
        //внешний ключ на таблицу ItemsQuality
        public ItemsQuality ItemQualityId { get; set; }
        //внешний ключ на таблицу ItemsRare
        public ItemsRare RareId { get; set; }
        //внешний ключ на таблицу ItemsType
        public ItemsType TypeId { get; set; }
        //внешний ключ на таблицу ItemsCollections
        public ItemsCollections CollectionId { get; set; }
        
        //внешний ключ на таблицу inventory, внутри создастся поле ItemId
        public List<Inventory>? Inventories { get; set; }
    }

    [Table("items_quality")]
    public class ItemsQuality
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdQuality { get; set; }
        [Required]
        public string NameQuality { get; set; }

    }

    [Table("items_rare")]
    public class ItemsRare
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdRare { get; set; }
        [Required]
        public string NameRare { get; set; }

    }

    [Table("items_type")]
    public class ItemsType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdType { get; set; }
        [Required]
        public string NameType { get; set; }

    }

    [Table("items_collections")]
    public class ItemsCollections
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdCollection { get; set; }
        [Required]
        public string NameCollection { get; set; }

    }


    public class SiteContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Inventory> Inventory => Set<Inventory>();
        public DbSet<AllItems> AllItems => Set<AllItems>();
        public DbSet<ItemsQuality> ItemsQuality => Set<ItemsQuality>();
        public DbSet<ItemsRare> itemsRares => Set<ItemsRare>();
        public DbSet<ItemsType> ItemsType => Set<ItemsType>();
        public DbSet<ItemsCollections> ItemsCollections => Set<ItemsCollections>();


        public SiteContext(DbContextOptions<SiteContext> options) : base(options) { Database.EnsureCreated(); }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //добавление начальных данных для таблицы Users
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Login = "test1", Password = "pass1" },
                new User { UserId = 2, Login = "test2", Password = "pass2" }
            );

            //добавление начальных данных для таблицы ItemsQuality
            modelBuilder.Entity<ItemsQuality>().HasData(
                new ItemsQuality { IdQuality = 1, NameQuality = "Закаленное в боях"},
                new ItemsQuality { IdQuality = 2, NameQuality = "Поношенное" },
                new ItemsQuality { IdQuality = 3, NameQuality = "После полевых испытаний" },
                new ItemsQuality { IdQuality = 4, NameQuality = "Немного поношенное" },
                new ItemsQuality { IdQuality = 5, NameQuality = "Прямо с завода" }
            );

            //добавление начальных данных для таблицы ItemsRare
            modelBuilder.Entity<ItemsRare>().HasData(
                new ItemsRare { IdRare = 1, NameRare = "Ширпотреб" },
                new ItemsRare { IdRare = 2, NameRare = "Промышленное качество" },
                new ItemsRare { IdRare = 3, NameRare = "Армейское качество" },
                new ItemsRare { IdRare = 4, NameRare = "Запрещённое" },
                new ItemsRare { IdRare = 5, NameRare = "Засекреченное" },
                new ItemsRare { IdRare = 6, NameRare = "Тайное" },
                new ItemsRare { IdRare = 7, NameRare = "Тайное*" },
                new ItemsRare { IdRare = 8, NameRare = "Сувенир" }
            );

            //добавление начальных данных для таблицы ItemsType
            modelBuilder.Entity<ItemsType>().HasData(
                new ItemsType { IdType = 1, NameType = "Пистолет" },
                new ItemsType { IdType = 2, NameType = "Пистолет-пулемёт" },
                new ItemsType { IdType = 3, NameType = "Штурмовая винтовка" },
                new ItemsType { IdType = 4, NameType = "Снайперская винтовка" },
                new ItemsType { IdType = 5, NameType = "Дробовик" },
                new ItemsType { IdType = 6, NameType = "Нож" },
                new ItemsType { IdType = 7, NameType = "Перчатки" },
                new ItemsType { IdType = 8, NameType = "Другое" }
            );

            //добавление начальных данных для таблицы ItemsCollections
            modelBuilder.Entity<ItemsCollections>().HasData(
                new ItemsCollections { IdCollection = 1, NameCollection = "Коллекция «eSports 2013»" },
                new ItemsCollections { IdCollection = 2, NameCollection = "Коллекция «Vertigo»" },
                new ItemsCollections { IdCollection = 3, NameCollection = "Коллекция «Militia»" },
                new ItemsCollections { IdCollection = 4, NameCollection = "Коллекция «Arms Deal»" },
                new ItemsCollections { IdCollection = 5, NameCollection = "Коллекция «Inferno»" },
                new ItemsCollections { IdCollection = 6, NameCollection = "Коллекция «Aztec»" },
                new ItemsCollections { IdCollection = 7, NameCollection = "Коллекция «Nuke»" },
                new ItemsCollections { IdCollection = 8, NameCollection = "Коллекция «Office»" },
                new ItemsCollections { IdCollection = 9, NameCollection = "Коллекция «Dust»" },
                new ItemsCollections { IdCollection = 10, NameCollection = "Коллекция «Assault»" },
                new ItemsCollections { IdCollection = 11, NameCollection = "Коллекция «Браво»" },
                new ItemsCollections { IdCollection = 12, NameCollection = "Коллекция «Альфа»" },
                new ItemsCollections { IdCollection = 13, NameCollection = "Коллекция «Arms Deal 2»" },
                new ItemsCollections { IdCollection = 14, NameCollection = "Коллекция «Train»" },
                new ItemsCollections { IdCollection = 15, NameCollection = "Коллекция «Lake»" },
                new ItemsCollections { IdCollection = 16, NameCollection = "Коллекция «Dust 2»" },
                new ItemsCollections { IdCollection = 17, NameCollection = "Коллекция «Mirage»" },
                new ItemsCollections { IdCollection = 18, NameCollection = "Коллекция «Italy»" },
                new ItemsCollections { IdCollection = 19, NameCollection = "Коллекция «Winter Offensive»" },
                new ItemsCollections { IdCollection = 20, NameCollection = "Коллекция «eSports 2013 Winter»" },
                new ItemsCollections { IdCollection = 21, NameCollection = "Коллекция «Arms Deal 3»" },
                new ItemsCollections { IdCollection = 22, NameCollection = "Коллекция «Феникс»" },
                new ItemsCollections { IdCollection = 23, NameCollection = "Охотничья коллекция" },
                new ItemsCollections { IdCollection = 24, NameCollection = "Коллекция «Bank»" },
                new ItemsCollections { IdCollection = 25, NameCollection = "Коллекция «Cobblestone»" },
                new ItemsCollections { IdCollection = 26, NameCollection = "Коллекция «Overpass»" },
                new ItemsCollections { IdCollection = 27, NameCollection = "Коллекция «Baggage»" },
                new ItemsCollections { IdCollection = 28, NameCollection = "Коллекция «Прорыв»" },
                new ItemsCollections { IdCollection = 29, NameCollection = "Коллекция «eSports 2014 Summer»" },
                new ItemsCollections { IdCollection = 30, NameCollection = "Коллекция «Cache»" },
                new ItemsCollections { IdCollection = 31, NameCollection = "Коллекция «Авангард»" },
                new ItemsCollections { IdCollection = 32, NameCollection = "Коллекция из хромированного кейса" },
                new ItemsCollections { IdCollection = 33, NameCollection = "Коллекция из хромированного кейса #2" },
                new ItemsCollections { IdCollection = 34, NameCollection = "Коллекция «Фальшион»" },
                new ItemsCollections { IdCollection = 35, NameCollection = "Коллекция «Чик-чик»" },
                new ItemsCollections { IdCollection = 36, NameCollection = "Коллекция «Боги и чудовища»" },
                new ItemsCollections { IdCollection = 37, NameCollection = "Коллекция «Рассвет»" },
                new ItemsCollections { IdCollection = 38, NameCollection = "Коллекция из тёмного кейса" },
                new ItemsCollections { IdCollection = 39, NameCollection = "Револьверная коллекция" },
                new ItemsCollections { IdCollection = 40, NameCollection = "Коллекция «Дикое пламя»" },
                new ItemsCollections { IdCollection = 41, NameCollection = "Коллекция из хромированного кейса #3" },
                new ItemsCollections { IdCollection = 42, NameCollection = "Коллекция «Гамма»" },
                new ItemsCollections { IdCollection = 43, NameCollection = "Коллекция «Гамма 2»" },
                new ItemsCollections { IdCollection = 44, NameCollection = "Перчаточная коллекция" },
                new ItemsCollections { IdCollection = 45, NameCollection = "Коллекция «Спектр»" },
                new ItemsCollections { IdCollection = 46, NameCollection = "Коллекция «Горизонт»" },
                new ItemsCollections { IdCollection = 47, NameCollection = "Коллекция «Inferno 2018»" },
                new ItemsCollections { IdCollection = 48, NameCollection = "Коллекция «Nuke 2018»" },
                new ItemsCollections { IdCollection = 49, NameCollection = "Коллекция «Запретная зона»" },
                new ItemsCollections { IdCollection = 50, NameCollection = "Коллекция «Blacksite»" },
                new ItemsCollections { IdCollection = 51, NameCollection = "Коллекция «Решающий момент»" },
                new ItemsCollections { IdCollection = 52, NameCollection = "Коллекция «Призма»" },
                new ItemsCollections { IdCollection = 53, NameCollection = "Коллекция «Рентген»" },
                new ItemsCollections { IdCollection = 54, NameCollection = "Коллекция «CS20»" },
                new ItemsCollections { IdCollection = 55, NameCollection = "Коллекция «Расколотая сеть»" },
                new ItemsCollections { IdCollection = 56, NameCollection = "Коллекция «Север»" },
                new ItemsCollections { IdCollection = 57, NameCollection = "Коллекция «St. Marc»" },
                new ItemsCollections { IdCollection = 58, NameCollection = "Коллекция «Canals»" },
                new ItemsCollections { IdCollection = 59, NameCollection = "Коллекция «Призма 2»" },
                new ItemsCollections { IdCollection = 60, NameCollection = "Коллекция «Разлом»" },
                new ItemsCollections { IdCollection = 61, NameCollection = "Коллекция «Хаос»" },
                new ItemsCollections { IdCollection = 62, NameCollection = "Коллекция «Ancient»" },
                new ItemsCollections { IdCollection = 63, NameCollection = "Коллекция «Контроль»" },
                new ItemsCollections { IdCollection = 64, NameCollection = "Коллекция операции «Сломанный клык»" },
                new ItemsCollections { IdCollection = 65, NameCollection = "Коллекция «Змеиный укус»" },
                new ItemsCollections { IdCollection = 66, NameCollection = "Коллекция операции «Хищные воды»" },
                new ItemsCollections { IdCollection = 67, NameCollection = "Коллекция Vertigo 2021" },
                new ItemsCollections { IdCollection = 68, NameCollection = "Коллекция Mirage 2021" },
                new ItemsCollections { IdCollection = 69, NameCollection = "Коллекция Dust 2 2021" },
                new ItemsCollections { IdCollection = 70, NameCollection = "Коллекция Train 2021" },
                new ItemsCollections { IdCollection = 71, NameCollection = "Коллекция «Грёзы и кошмары»" },
                new ItemsCollections { IdCollection = 72, NameCollection = "The Recoil Collection" },
                new ItemsCollections { IdCollection = 73, NameCollection = "The Revolution Collection" },
                new ItemsCollections { IdCollection = 74, NameCollection = "The Anubis Collection" }
            );

        }
    }
}
