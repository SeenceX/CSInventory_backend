using CSInventory.Data;
using CSInventory.Managers;
using CSInventoryDatabase.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace CSInventory.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryManager _inventoryManager;
        public InventoryController(IInventoryManager inventoryManager)
        {
            _inventoryManager = inventoryManager;
        }

        [HttpGet("{Id:int}")]
        public async Task<List<InventoryDto>> GetUserInventoryById(int Id)
        {
            return await _inventoryManager.GetUserInventoryById(Id);
        }
        [HttpPost("add")]
        public async Task<string> AddUserInventoryItemById(int userId, int itemId)
        {
            return await _inventoryManager.AddUserInventoryItemById(userId, itemId);
        }
        [HttpPost("delete")]
        public async Task<string> DeleteUserInventoryItemById(int userId, int itemId)
        {
            return await _inventoryManager.DeleteUserInventoryItemById(userId,  itemId);
        }
        [HttpPost("change")]
        public async Task<string> ChangeUserInventoryItemById(int userId, int itemId, int itemPrice)
        {
            return await _inventoryManager.ChangeUserInventoryItemById( userId,  itemId,  itemPrice);
        }
    }
}
