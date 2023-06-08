using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
{

    

    [Table("items_quality")]
    public class ItemQuality
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdQuality { get; set; }
        [Required]
        public string NameQuality { get; set; }

    }

    
}
