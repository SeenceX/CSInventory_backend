using System.Linq;
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

        public async Task<List<InventoryDto>> GetUserInventoryById(int id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == id);
            if (user == null)
            {
                return null;
            }


            using (var context = _dbContext)
            {
                var res = from a in context.AllItems
                            join q in context.ItemsQuality on a.ItemsQuality.IdQuality equals q.IdQuality
                            join r in context.itemsRares on a.itemsRare.IdRare equals r.IdRare
                            join t in context.ItemsType on a.ItemsType.IdType equals t.IdType
                            join c in context.ItemsCollections on a.ItemCollection.IdCollection equals c.IdCollection
                            join inv in context.Inventory on a.ItemId equals inv.AllItems.ItemId
                            where inv.User.UserId == id
                            select new InventoryDto
                            {
                                ItemId = a.ItemId,
                                ItemImg = a.ItemImg,
                                ItemName = a.ItemName,
                                ItemCount = inv.ItemCount,
                                InitialPrice = inv.InitialPrice,
                                CurrentPrice = a.ItemPrice,
                                ItemQuality = q.NameQuality,
                                ItemRare = r.NameRare,
                                ItemType = t.NameType,
                                ItemCollection = c.NameCollection
                            };

                return res.ToList();
               
            }
        }
        public async Task<string> AddUserInventoryItemById(int userId, int itemId)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            if (user == null)
            {
                return "Ошибка пользователя";
            }
            using (var context = _dbContext)
            {
                var res = from a in context.Inventory
                          where a.Id == userId
                          select a.AllItems;
                res.Append<AllItems>(x => x = context.AllItems.Where(x => x.ItemId == itemId));
                context.SaveChangesAsync();
                //context.ExecuteUpdate(s => s.SetProperty(u => u.AllItems, u => u.AllItems.Append<AllItems>(context.AllItems.Where(x => x.ItemId == itemId))));
                
                //using context.AllItems.Append<AllItems>(context.AllItems.Where(x => x.ItemId == itemId));
                return "Предмет успешно добавлен";

            }
        }
        public async Task<List<InventoryDto>> DeleteUserInventoryItemById(int userId, int itemId)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            if (user == null)
            {
                return "Ошибка пользователя";
            }
            using (var context = _dbContext)
            {
                //context.Inventory.Where(x => x.User == user).ExecuteDelete

            }
        }
        Task<List<InventoryDto>> ChangeUserInventoryItemById(int userId, int itemId, int itemPrice)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            if (user == null)
            {
                return "Ошибка пользователя";
            }
            using (var context = _dbContext)
            {
                var data = from a in context.Inventory
                           where a.User == user
                           select a.AllItems;
                

            }
        }
    }
}
