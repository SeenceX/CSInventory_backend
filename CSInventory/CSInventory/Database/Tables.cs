using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Database
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


    public class SiteContext : DbContext
    {
        public DbSet<User> Users => Set<User>();
        public DbSet<Inventory> Inventory => Set<Inventory>();
        public DbSet<AllItems> AllItems => Set<AllItems>();
        public DbSet<ItemsQuality> ItemsQuality => Set<ItemsQuality>();

        public SiteContext(DbContextOptions<SiteContext> options) : base(options) { Database.EnsureCreated(); }
    }
}
