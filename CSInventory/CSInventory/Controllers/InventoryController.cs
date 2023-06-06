using CSInventory.Data;
using CSInventory.Managers;
using CSInventoryDatabase.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;

namespace CSInventory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InventoryController : ControllerBase
    {
        private readonly IInventoryManager _inventoryManager;
        public InventoryController(IInventoryManager inventoryManager)
        {
            _inventoryManager = inventoryManager;
        }

        [HttpGet("{Id:int}")]
        public async Task<List<UserDto>> GetUserInventoryById(int Id)
        {
            return await _inventoryManager.GetUserInventoryById(Id);
        }
    }
}
