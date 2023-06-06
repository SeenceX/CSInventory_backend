using CSInventory.Data;

namespace CSInventory.Managers
{
    public interface IInventoryManager
    {
        Task<List<InventoryDto>> GetUserInventoryById(int id);
    }
}
