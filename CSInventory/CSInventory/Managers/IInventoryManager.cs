using CSInventory.Data;

namespace CSInventory.Managers
{
    public interface IInventoryManager
    {
        Task<List<InventoryDto>> GetUserInventoryById(int id);
        Task<string> AddUserInventoryItemById(int userId, int itemId);
        Task<string> DeleteUserInventoryItemById(int userId, int itemId);
        Task<string> ChangeUserInventoryItemById(int userId, int itemId, int itemPrice);
    }
}
