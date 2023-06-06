using CSInventoryDatabase.Data;
using CSInventoryDatabase.Managers;
using Microsoft.AspNetCore.Mvc;

namespace CSInventoryDatabase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController: ControllerBase
    {
        private readonly IUsersManager _usersManager;
        public UsersController(IUsersManager usersManager)
        {
            _usersManager = usersManager;
        }

        [HttpGet]
        public async Task<List<UserDto>> GetUsers()
        {
            return await _usersManager.Get();
        }

        [HttpGet("{Id:int}")]
        public async Task<UserDto> GetUserById(int Id)
        {
            return await _usersManager.GetById(Id);
        }

        [HttpPost("registration")]
        public async Task<UserDto> CreateUser([FromBody] CreateUserRequest request)
        {
            return await _usersManager.Registration(request);
        }

        [HttpPost("login")]
        public async Task<UserDto> GetByLogPass(CreateUserRequest request)
        {
            return await _usersManager.Login(request);
        }
    }
}
