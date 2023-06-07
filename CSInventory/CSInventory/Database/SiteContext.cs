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

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Login = "test1", Password = "pass1" },
                new User { UserId = 2, Login = "test2", Password = "pass2" }
            );

            //добавление начальных данных для таблицы ItemsQuality
            modelBuilder.Entity<ItemQuality>().HasData(
                new ItemQuality { IdQuality = 1, NameQuality = "-" },
                new ItemQuality { IdQuality = 2, NameQuality = "Закаленное в боях" },
                new ItemQuality { IdQuality = 3, NameQuality = "Поношенное" },
                new ItemQuality { IdQuality = 4, NameQuality = "После полевых испытаний" },
                new ItemQuality { IdQuality = 5, NameQuality = "Немного поношенное" },
                new ItemQuality { IdQuality = 6, NameQuality = "Прямо с завода" }
            );

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

            //добавление начальных данных для таблицы ItemsCollections
            modelBuilder.Entity<ItemCollection>().HasData(
                new ItemCollection { IdCollection = 1, NameCollection = "-" },
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

            //добавление начальных данных для таблицы AllItems
            modelBuilder.Entity<AllItems>().HasData(
                new AllItems { ItemId = 1, ItemImg = "test", ItemName = "P90 | Азимов", ItemPrice = "592.93₽", ItemsQuality = "Закаленное в боях", itemsRare = "Тайное", ItemsType = "Пистолет-пулемёт", ItemCollection = "Прорыв" },
                new AllItems { ItemId = 2, ItemImg = "test", ItemName = "Штык-нож | Кровавая паутина", ItemPrice = "306 156.69₽", ItemsQuality = "Прямо с завода", itemsRare = "Тайное", ItemsType = "Нож", ItemCollection = "-" },
                new AllItems { ItemId = 3, ItemImg = "test", ItemName = "USP-S | Кайман", ItemPrice = "3 139₽", ItemsQuality = "После полевых испытаний", itemsRare = "Засекреченное", ItemsType = "Пистолет", ItemCollection = "Охотничья коллекция" },
                new AllItems { ItemId = 4, ItemImg = "test", ItemName = "AK-47 | Кровавый спорт", ItemPrice = "7 590₽", ItemsQuality = "После полевых испытаний", itemsRare = "Тайное", ItemsType = "Штурмовая винтовка", ItemCollection = "Спектр" },
                new AllItems { ItemId = 5, ItemImg = "test", ItemName = "AWP | Электрический улей", ItemPrice = "3 315.13₽", ItemsQuality = "После полевых испытаний", itemsRare = "Засекреченное", ItemsType = "Снайперская винтовка", ItemCollection = "Коллекция «eSports 2013»" },
                new AllItems { ItemId = 6, ItemImg = "test", ItemName = "M4A4 | Зирка", ItemPrice = "2 159.79₽", ItemsQuality = "После полевых испытаний", itemsRare = "Запрещённое", ItemsType = "Штурмовая винтовка", ItemCollection = "Браво" },
                new AllItems { ItemId = 7, ItemImg = "test", ItemName = "M4A4 | Тёмное цветение", ItemPrice = "1500₽", ItemsQuality = "Прямо с завода", itemsRare = "Промышленное качество", ItemsType = "Штурмовая винтовка", ItemCollection = "St. Marc" },
                new AllItems { ItemId = 8, ItemImg = "test", ItemName = "Оружейный кейс операции «Прорыв»", ItemPrice = "479.08₽", ItemsQuality = "-", itemsRare = "Базовый класс", ItemsType = "Другое", ItemCollection = "Прорыв" },
                new AllItems { ItemId = 9, ItemImg = "test", ItemName = "MAG-7 | Флотский блеск", ItemPrice = "12₽", ItemsQuality = "Немного поношенное", itemsRare = "Ширпотреб", ItemsType = "Дробовик", ItemCollection = "Коллекция Mirage 2021" },
                new AllItems { ItemId = 10, ItemImg = "test", ItemName = "Автомат «Галиль» | Щелкунчик", ItemPrice = "465.29₽", ItemsQuality = "Закаленное в боях", itemsRare = "Тайное", ItemsType = "Штурмовая винтовка", ItemCollection = "Коллекция из хромированного кейса" },
                new AllItems { ItemId = 11, ItemImg = "test", ItemName = "Glock-18 | Дух воды", ItemPrice = "1 207.14₽", ItemsQuality = "Прямо с завода", itemsRare = "Засекреченное", ItemsType = "Пистолет", ItemCollection = "Прорыв" },
                new AllItems { ItemId = 12, ItemImg = "test", ItemName = "Зимний кейс eSports 2013", ItemPrice = "643.62₽", ItemsQuality = "-", itemsRare = "Базовый класс", ItemsType = "Другое", ItemCollection = "Коллекция «eSports 2013" },
                new AllItems { ItemId = 13, ItemImg = "test", ItemName = "FAMAS | Ночной Борре", ItemPrice = "442.75₽", ItemsQuality = "После полевых испытаний", itemsRare = "Ширпотреб", ItemsType = "Штурмовая винтовка", ItemCollection = "Север" },
                new AllItems { ItemId = 14, ItemImg = "test", ItemName = "Ключ от кейса Winter Offensive", ItemPrice = "1111₽", ItemsQuality = "-", itemsRare = "Базовый класс", ItemsType = "Другое", ItemCollection = "Winter Offensive" },
                new AllItems { ItemId = 15, ItemImg = "test", ItemName = "MAC-10 | Неоновый гонщик", ItemPrice = "560₽", ItemsQuality = "После полевых испытаний", itemsRare = "Тайное", ItemsType = "Пистолет-пулемёт", ItemCollection = "Коллекция из хромированного кейса #2" },
                new AllItems { ItemId = 16, ItemImg = "test", ItemName = "AK-47 | Картель", ItemPrice = "862.9₽", ItemsQuality = "Поношенное", itemsRare = "Засекреченное", ItemsType = "Штурмовая винтовка", ItemCollection = "Коллекция из хромированного кейса" },
                new AllItems { ItemId = 17, ItemImg = "test", ItemName = "Glock-18 | Реактор", ItemPrice = "364.99₽", ItemsQuality = "После полевых испытаний", itemsRare = "Армейское качество", ItemsType = "Пистолет", ItemCollection = "Cache" },
                new AllItems { ItemId = 18, ItemImg = "test", ItemName = "Автомат «Галиль» | Леденец", ItemPrice = "567.69₽", ItemsQuality = "Прямо с завода", itemsRare = "Армейское качество", ItemsType = "Штурмовая винтовка", ItemCollection = "Фальшион" },
                new AllItems { ItemId = 19, ItemImg = "test", ItemName = "SCAR-20 | Сайрекс", ItemPrice = "4 370₽", ItemsQuality = "После полевых испытаний", itemsRare = "Засекреченное", ItemsType = "Снайперская винтовка", ItemCollection = "Охотничья коллекция" },
                new AllItems { ItemId = 20, ItemImg = "test", ItemName = "AWP | Медуза", ItemPrice = "290 000₽", ItemsQuality = "После полевых испытаний", itemsRare = "Тайное", ItemsType = "Снайперская винтовка", ItemCollection = "Боги и чудовища" }

            );

        }
    }
}
