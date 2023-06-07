using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
{

   

    [Table("items_rare")]
    public class ItemRare
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdRare { get; set; }
        [Required]
        public string NameRare { get; set; }

    }

    
}
