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
                new AllItems { ItemId = 1, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpopuP1FAR17OORIXBD_9W_mY-dqP_xMq3IqWdQ-sJ0xLvEpNugjQTm80BvZ2_0doTAdFBraFCE8lnoyers15PptZjMyiEyuCQ8pSGKT1_PUsY/64fx64f", ItemName = "P90 | Азимов", ItemPrice = "592.93", ItemsQuality = "Закаленное в боях", itemsRare = "Тайное", ItemsType = "Пистолет-пулемёт", ItemCollection = "Прорыв" },
                new AllItems { ItemId = 2, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpotLu8JAllx8zAaAJV6d6lq4yCkP_gDLfQhGxUppwj3r-Rpd3zjAy38xFsMGn0I9LGcA49Zw2B_VO5wL_r1Ja-vJrMySB9-n51NRRkGyg/64fx64f", ItemName = "Штык-нож | Кровавая паутина", ItemPrice = "306 156.69", ItemsQuality = "Прямо с завода", itemsRare = "Тайное", ItemsType = "Нож", ItemCollection = "-" },
                new AllItems { ItemId = 3, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpoo6m1FBRp3_bGcjhQ09-jq4uKnvr1PYTck29Y_chOhujT8om72Ay2_ENuY26ncoDBd1I_MlCBrgW5ye_u1sC_vJ6YyXtgsiYh7HnUywv330-jy4MGQg/64fx64f", ItemName = "USP-S | Кайман", ItemPrice = "3 139", ItemsQuality = "После полевых испытаний", itemsRare = "Засекреченное", ItemsType = "Пистолет", ItemCollection = "Охотничья коллекция" },
                new AllItems { ItemId = 4, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhnwMzJemkV0966m4-PhOf7Ia_um25V4dB8teXA54vwxlCy-0Y_YTimdoLEdwU5YguEq1i9k-e515e-tM_JzCYwuiNx4SyLmxapwUYbIBBxC48/64fx64f", ItemName = "AK-47 | Кровавый спорт", ItemPrice = "7 590", ItemsQuality = "После полевых испытаний", itemsRare = "Тайное", ItemsType = "Штурмовая винтовка", ItemCollection = "Спектр" },
                new AllItems { ItemId = 5, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot621FA957PvBZzh94dmynZWGqPv1IbzU2DMEv8Rw3-3Epo6giQyxqkFoYGChJ4adcQ46YAzY_1DswObvgMO_u8nXiSw0zFWmqYw/64fx64f", ItemName = "AWP | Электрический улей", ItemPrice = "3 315.13", ItemsQuality = "После полевых испытаний", itemsRare = "Засекреченное", ItemsType = "Снайперская винтовка", ItemCollection = "Коллекция «eSports 2013»" },
                new AllItems { ItemId = 6, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou-6kejhzw8zbZTxQ096klZaEqPrxN7LEm1Rd6dd2j6eT8I-iiQK2rUo6YWv0cNWVcgM_aV2GrwPrlbrvhpK1tZ7Mz3tj6SJx-z-DyOOk6P2x/64fx64f", ItemName = "M4A4 | Зирка", ItemPrice = "2 159.79", ItemsQuality = "После полевых испытаний", itemsRare = "Запрещённое", ItemsType = "Штурмовая винтовка", ItemCollection = "Браво" },
                new AllItems { ItemId = 7, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou-6kejhzw8zKZDl97tCjkb-HnvD8J4Tdl3lW7Yt32bjDrdSn2gK3_ERoa2n2II7EclU_NF7S_1m_k7u-jcC_tZnPwHJlpGB8svQRy-TR/64fx64f", ItemName = "M4A4 | Тёмное цветение", ItemPrice = "1500", ItemsQuality = "Прямо с завода", itemsRare = "Промышленное качество", ItemsType = "Штурмовая винтовка", ItemCollection = "St. Marc" },
                new AllItems { ItemId = 8, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXU5A1PIYQNqhpOSV-fRPasw8rsUFJ5KBFZv668FFMu1aPMI24auITjxteJwPXxY72AkGgIvZAniLjHpon2jlbl-kpvNjz3JJjVLFG9rl1YLQ/64fx64f", ItemName = "Оружейный кейс операции «Прорыв»", ItemPrice = "479.08", ItemsQuality = "-", itemsRare = "Базовый класс", ItemsType = "Другое", ItemCollection = "Прорыв" },
                new AllItems { ItemId = 9, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou7uifDhh3szGcCtb08--nY6OqPv9NLPFqWdQ-sJ0xO_Fp4qk2gDlqBZsMT-iJYDHIFRqaVHX-we5w-brg5K-tc6awXVn7iA8pSGKCZDD33w/64fx64f", ItemName = "MAG-7 | Флотский блеск", ItemPrice = "12", ItemsQuality = "Немного поношенное", itemsRare = "Ширпотреб", ItemsType = "Дробовик", ItemCollection = "Коллекция Mirage 2021" },
                new AllItems { ItemId = 10, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposbupIgthwczLZAJF7dC_mL-KleX1ILLemFRZ7cRnk9bN9J7yjRq3-hI-a2imIIbAdwJoN1_W_VXvlbjv1sW_75rOyydmuCQk4HnUlxfjn1gSOX65Pfcs/64fx64f", ItemName = "Автомат «Галиль» | Щелкунчик", ItemPrice = "465.29", ItemsQuality = "Закаленное в боях", itemsRare = "Тайное", ItemsType = "Штурмовая винтовка", ItemCollection = "Коллекция из хромированного кейса" },
                new AllItems { ItemId = 11, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposbaqKAxf0Ob3djFN79f7mImagvLnML7fglRd4cJ5ntbN9J7yjRrl_kI5amz3cdKRI1NoY1CDqQK7xLrv1se47pnKmHU3syYm4SnemUTkn1gSOYPIEaei/64fx64f", ItemName = "Glock-18 | Дух воды", ItemPrice = "1 207.14", ItemsQuality = "Прямо с завода", itemsRare = "Засекреченное", ItemsType = "Пистолет", ItemCollection = "Прорыв" },
                new AllItems { ItemId = 12, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXU5A1PIYQNqhpOSV-fRPasw8rsVk5kKhZDpYX3e1Yz7KKcPzwav9jnzdfdlfWmY7_TzmkF6ZMlj77A9o3x0Qe1qhBkZGjxI9LBJgMgIQaH1G7WeaA/64fx64f", ItemName = "Зимний кейс eSports 2013", ItemPrice = "643.62", ItemsQuality = "-", itemsRare = "Базовый класс", ItemsType = "Другое", ItemCollection = "Коллекция «eSports 2013" },
                new AllItems { ItemId = 13, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposLuoKhRfwOP3ejNN-M-Jloyeksj5Nr_Yg2Zu5MRjjeyPp9ik2AHi-0s4ZG_3ctOSc1BvNVzYrlG7wby60Z67uJrNwSdruCV05mGdwUL0cJQQGQ/64fx64f", ItemName = "FAMAS | Ночной Борре", ItemPrice = "442.75", ItemsQuality = "После полевых испытаний", itemsRare = "Ширпотреб", ItemsType = "Штурмовая винтовка", ItemCollection = "Север" },
                new AllItems { ItemId = 14, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXX7gNTPcUxuxpJSXPbQv2S1MDeXkh6LBBOievrLVY2i6ebKDsbv47hw4TTlaSsZeKIxztQu8B03L2Y8Imh2Aftrhc-Z3ezetFDsuzS1g/64fx64f", ItemName = "Ключ от кейса Winter Offensive", ItemPrice = "1111", ItemsQuality = "-", itemsRare = "Базовый класс", ItemsType = "Другое", ItemCollection = "Winter Offensive" },
                new AllItems { ItemId = 15, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpou7umeldf0Ob3fDxBvYyJmoWEmeX9N77DqWZU7Mxkh9bN9J7yjRrl-0E-NTqnJ4OdewQ3NQmF-FO8yerngpe5upzOzCc273Qrsy2LnRGwn1gSOcWK_T7P/64fx64f", ItemName = "MAC-10 | Неоновый гонщик", ItemPrice = "560", ItemsQuality = "После полевых испытаний", itemsRare = "Тайное", ItemsType = "Пистолет-пулемёт", ItemCollection = "Коллекция из хромированного кейса #2" },
                new AllItems { ItemId = 16, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpot7HxfDhhwszJemkV09-3hpSOm8j5Nr_Yg2Zu5MRjjeyP8I6jjlHg-UJsMG33J9CRegI3ZgrTrlS3wevs05616pmcmnBg63Mh5GGdwUIXr_jb8w/64fx64f", ItemName = "AK-47 | Картель", ItemPrice = "862", ItemsQuality = "Поношенное", itemsRare = "Засекреченное", ItemsType = "Штурмовая винтовка", ItemCollection = "Коллекция из хромированного кейса" },
                new AllItems { ItemId = 17, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposbaqKAxf0v73fyhB4Nm3hr-bluPgNqnfx1RW5MpygdbM8Ij8nVmLpxIuNDztLNeXegQ3YQzV-li9ye_pjZW0uJvJnCFguCAhtHvVzhG01U4fauZmg-veFwv4TERPOw/64fx64f", ItemName = "Glock-18 | Реактор", ItemPrice = "364.99", ItemsQuality = "После полевых испытаний", itemsRare = "Армейское качество", ItemsType = "Пистолет", ItemCollection = "Cache" },
                new AllItems { ItemId = 18, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgposbupIgthwczLZAJF7dC_mIGZqOf1Ia_YlWdU-_p9g-7J4bP5iUazrl1kZGrxcoCRJgM9NQqD8wO-kunsh5C4vZvMzCZn7Ckr5H3Zyx3k0EsfcKUx0tENzMgC/64fx64f", ItemName = "Автомат «Галиль» | Леденец", ItemPrice = "567.69", ItemsQuality = "Прямо с завода", itemsRare = "Армейское качество", ItemsType = "Штурмовая винтовка", ItemCollection = "Фальшион" },
                new AllItems { ItemId = 19, ItemImg = "https://community.cloudflare.steamstatic.com/economy/image/-9a81dlWLwJ2UUGcVs_nsVtzdOEdtWwKGZZLQHTxDZ7I56KU0Zwwo4NUX4oFJZEHLbXH5ApeO4YmlhxYQknCRvCo04DEVlxkKgpopbmkOVUw7PDdTi5B7c6Jl5mZku_LPr7Vn35c18lwmO7Eu4rz2gLtrkE5ZGH0doHBdQU_YlHTrAO7yebs08O8vMnLwCBjs3Fx5XzD30vgG8tICKs/64fx64f", ItemName = "SCAR-20 | Сайрекс", ItemPrice = "4 370", ItemsQuality = "После полевых испытаний", itemsRare = "Засекреченное", ItemsType = "Снайперская винтовка", ItemCollection = "Охотничья коллекция" },
                

            );

        }
    }
}
