using CSInventoryDatabase.Data;

namespace CSInventory.Managers
{
    public interface IInventoryManager
    {
        Task<List<UserDto>> GetUserInventoryById(int id);
    }
}
