using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
{

   /*

    [Table("all_items")]
    public class AllItems
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int ItemId { get; set; }
        public string ItemImg { get; set; }
        
        public string ItemName { get; set; }
        
        public decimal ItemPrice { get; set; }
        [ForeignKey("IdQuality")]
        public ItemQuality ItemsQuality { get; set; } // навигационное свойство
        [ForeignKey("IdRare")]
        public ItemRare itemsRare { get; set; }
        [ForeignKey("IdType")]
        public ItemType ItemsType { get; set; }
        [ForeignKey("IdCollection")]
        //внешний ключ на таблицу ItemsCollections
        public ItemCollection ItemCollection { get; set; }
        
        //внешний ключ на таблицу inventory, внутри создастся поле ItemId
        public List<Inventory> Inventories { get; set; }
    }
   */
    


   

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //добавление начальных данных для таблицы Users
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
