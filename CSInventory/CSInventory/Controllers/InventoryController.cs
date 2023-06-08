using CSInventory.Data;
using CSInventory.Database;
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

        /*[HttpGet]
        public async Task<List<AllItems>> GetAllItems()
        {
            return await _inventoryManager.GetAllItems();
        }*/

        [HttpGet("{ItemName}")]
        public async Task<List<AllItems>> GetLikeName(string ItemName)
        {
            return await _inventoryManager.GetItemLikeName(ItemName);
        }


        [HttpGet("{Id:int}")]
        public async Task<List<InventoryDto>> GetUserInventoryById(int Id)
        {
            return await _inventoryManager.GetUserInventoryById(Id);
        }
        [HttpPost("add")]
        public async Task<string> AddUserInventoryItemById([FromBody] CreateInventoryRequest request)
        {
            return await _inventoryManager.AddUserInventoryItemById(request);
        }
        [HttpPost("delete")]
        public async Task<string> DeleteUserInventoryItemById([FromBody] CreateInventoryRequest request)//CreateInventoryRequest
        {
            return await _inventoryManager.DeleteUserInventoryItemById(request);
        }
        [HttpPost("change")]
        public async Task<string> ChangeUserInventoryItemById([FromBody] CreateInventoryRequest request, int itemPrice)
        {
            return await _inventoryManager.ChangeUserInventoryItemById(request, itemPrice);
        }
    }
}
