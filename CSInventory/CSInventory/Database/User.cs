using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CSInventoryDatabase.Database
{
    [Table("users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int UserId { get; set; }

        [Required]
        public string Login { get; set; }

        [Required]
        public string Password { get; set; }
        
        [Required]
        public DateTime RegistrationDate { get; set; }

        //внешний ключ на таблицу inventory, внутри которой создастся поле UserId связь один ко многиь (1->m)
        public List<Inventory>? Inventories { get; set; }


    }
}
