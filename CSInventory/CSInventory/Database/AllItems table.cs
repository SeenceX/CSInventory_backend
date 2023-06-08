using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
{

   

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
   
    
}
