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
    }
}
