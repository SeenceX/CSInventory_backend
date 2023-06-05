using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CSInventoryDatabase.Database
{
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
        [Required]
        public int ItemRare { get; set; }
        [Required]
        public int ItemType { get; set; }
        [Required]
        public int ItemCollection { get; set; }
        //внешний ключ на таблицу ItemsQuality
        public ItemsQuality ItemQualityId { get; set; }
        //внешний ключ на таблицу inventory, внутри создастся поле ItemId
        public List<Inventory>? Inventories { get; set; }
    }
}