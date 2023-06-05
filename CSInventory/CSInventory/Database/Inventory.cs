using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CSInventoryDatabase.Database
{
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
    }
}

