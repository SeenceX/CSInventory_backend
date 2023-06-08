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

        public async Task<List<AllItems>> GetAllItems()
        {
            var allitems = await _dbContext.AllItems.ToListAsync();
            return allitems.Select(x => new AllItems()
            {
                ItemId = x.ItemId,
                ItemImg = x.ItemImg,
                ItemName = x.ItemName,
                ItemPrice = x.ItemPrice,
                ItemsQuality = x.ItemsQuality,
                itemsRare = x.itemsRare,
                ItemsType = x.ItemsType,
                ItemCollection = x.ItemCollection
            }).ToList();
        }

        public Task<List<AllItems>> GetItemLikeName(string name)
        {
            using (_dbContext)
            {
                var items = _dbContext.AllItems.Where(i => i.ItemName.Contains(name)).ToList();
                return Task.FromResult(items);
            }
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

        public async Task<string> AddUserInventoryItemById(CreateInventoryRequest createInventoryRequest)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == createInventoryRequest.UserId);
            if (user == null)
            {
                return "Ошибка пользователя";
            }
            using (var context = _dbContext)
            {
                var inv = await context.AllItems.FirstAsync(x => x.ItemId == createInventoryRequest.ItemId);
                await context.Inventory.AddAsync(new Inventory
                {
                    //Id = await context.Inventory.Where(u => u.User == user).CountAsync() + 1,
                    User = user,
                    AllItems = inv,
                    ItemCount = 1,
                    InitialPrice = inv.ItemPrice,
                });
                await context.SaveChangesAsync();
                return "Добавление прошло успешно";
            }

        }
        public async Task<string> DeleteUserInventoryItemById(CreateInventoryRequest createInventoryRequest)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == createInventoryRequest.UserId);
            if (user == null)
            {
                return "Ошибка пользователя";
            }
            using (var context = _dbContext)
            {
                await context.Inventory.Where(x => (x.User == user) && (x.AllItems.ItemId == createInventoryRequest.ItemId)).ExecuteDeleteAsync();
                return "Удаление прошло успешно";
            }
        }
        public async Task<string> ChangeUserInventoryItemById(CreateInventoryRequest createInventoryRequest, int itemPrice)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == createInventoryRequest.UserId);
            if (user == null)
            {
                return "Ошибка пользователя";
            }
            using (var context = _dbContext)
            {
                await context.Inventory.Where(x => (x.User == user) && (x.AllItems.ItemId == createInventoryRequest.ItemId))
                    .ExecuteUpdateAsync(s => s.SetProperty(u => u.InitialPrice, u => itemPrice));
                return "Цена успешно изменена";
            }
        }
    }
}
