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
                var inv = await context.AllItems.FirstAsync(x => x.ItemId == itemId);
                await context.Inventory.AddAsync(new Inventory
                {
                    Id = await context.Inventory.Where(u => u.User == user).CountAsync()+1,
                    User = user,
                    AllItems = inv,
                    ItemCount = await context.Inventory.Where(u => u.User == user).CountAsync()+1,
                    InitialPrice = inv.ItemPrice,
                });
                await context.SaveChangesAsync();
                return "Добавление прошло успешно";
            }
            
        }
        public async Task<string> DeleteUserInventoryItemById(int userId, int itemId)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            if (user == null)
            {
                return "Ошибка пользователя";
            }
            using (var context = _dbContext)
            {
                await context.Inventory.Where(x => (x.User == user) && (x.AllItems.ItemId == itemId)).ExecuteDeleteAsync();
                return "Удаление прошло успешно";
            }
        }
        public async Task<string> ChangeUserInventoryItemById(int userId, int itemId, int itemPrice)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == userId);
            if (user == null)
            {
                return "Ошибка пользователя";
            }
            using (var context = _dbContext)
            {
                await context.Inventory.Where(x => (x.User == user) && (x.AllItems.ItemId == itemId))
                    .ExecuteUpdateAsync(s => s.SetProperty(u => u.InitialPrice, u => itemPrice));
                return "Цена успешно изменена";
            }
        }
    }
}
