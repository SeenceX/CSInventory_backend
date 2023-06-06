using CSInventory.Data;
using CSInventory.Database;
using CSInventoryDatabase.Data;
using Microsoft.EntityFrameworkCore;

namespace CSInventory.Managers
{
    public class InventoryManager : IInventoryManager
    {
        private readonly SiteContext _dbContext;
        public InventoryManager(SiteContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<UserDto>> GetUserInventoryById(int id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == id);
            if (user == null)
            {
                return null;
            }

            
            /*var result = _dbContext.Users
                .Join(_dbContext.Inventory, u => u.UserId, i => i.UserId, (u, i) => new { User = u, Inventory = i })
                .Join(_dbContext.AllItems, ii => ii.Inventory.ItemId, ai => ai.ItemId, (ii, ai) => new { InventoryAndUser = ii, AllItems = ai })
                .Select(r => new InventoryDto
                {
                    UserId = r.InventoryAndUser.User.UserId,
                    ItemId = r.AllItems.ItemId,
                    ItemName = r.AllItems.ItemName,
                    ItemCount = r.InventoryAndUser.Inventory.ItemCount,
                    InitialPrice = r.InventoryAndUser.Inventory.InitialPrice,
                    CurrentPrice = r.AllItems.ItemPrice,
                    ItemQuality = r.AllItems.ItemQualityId.NameQuality,
                    ItemRare = r.AllItems.RareId.NameRare,
                    ItemType = r.AllItems.TypeId.NameType,
                    ItemCollection = r.AllItems.CollectionId.NameCollection
                });*/


            
            return result;
        }
    }
}
