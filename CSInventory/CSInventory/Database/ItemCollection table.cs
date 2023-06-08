using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
{

    

    [Table("items_collection")]
    public class ItemCollection
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int IdCollection { get; set; }
        [Required]
        public string NameCollection { get; set; }

    }
    

}
