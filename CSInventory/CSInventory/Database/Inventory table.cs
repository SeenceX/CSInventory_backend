using CSInventory.Database;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

[Table("inventory")]
public class Inventory
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Required]
    public int Id { get; set; }
    [ForeignKey("UserId")]
    public User User { get; set; }

    [ForeignKey("ItemId")]
    public AllItems AllItems { get; set; }

    public int ItemCount { get; set; }

    public decimal InitialPrice { get; set; }


}