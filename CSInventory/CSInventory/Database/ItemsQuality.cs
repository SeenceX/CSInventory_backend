using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSInventoryDatabase.Database
{
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
}