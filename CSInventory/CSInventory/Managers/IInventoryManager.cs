using CSInventory.Data;
using CSInventory.Database;

namespace CSInventory.Managers
{
    public interface IInventoryManager
    {
        Task<List<InventoryDto>> GetUserInventoryById(int id);
        Task<string> AddUserInventoryItemById(CreateInventoryRequest createInventoryRequest);
        Task<string> DeleteUserInventoryItemById(CreateInventoryRequest createInventoryRequest);
        Task<string> ChangeUserInventoryItemById(CreateInventoryRequest createInventoryRequest, int itemPrice);
        Task<List<AllItems>> GetAllItems();
        Task<List<AllItems>> GetItemLikeName(string name);
    }
}