namespace CSInventory.Data
{
    public class InventoryDto
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int ItemCount { get; set; }
        public decimal InitialPrice { get; set; }
        public decimal CurrentPrice { get; set; }
        public string ItemQuality { get; set; }
        public string ItemRare { get; set; }
        public string ItemType { get; set; }
        public string ItemCollection { get; set; }

    }
}