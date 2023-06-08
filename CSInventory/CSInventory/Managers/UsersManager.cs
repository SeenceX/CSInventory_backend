using CSInventory.Database;
using CSInventoryDatabase.Data;
using Microsoft.EntityFrameworkCore;

namespace CSInventoryDatabase.Managers
{
    public class UsersManager : IUsersManager
    {
        private readonly SiteContext _dbContext;
        public UsersManager(SiteContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<UserDto>> Get()
        {
            var users = await _dbContext.Users.ToListAsync();
            return users.Select(x => new UserDto { Id = x.UserId, Login = x.Login, Password = x.Password }).ToList();
        }
        public async Task<UserDto> GetById(int id)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.UserId == id);
            if (user == null)
            {
                return null;
            }
            return new UserDto { Id = user.UserId, Login = user.Login, Password = user.Password };
        }
        public async Task<UserDto> Registration(CreateUserRequest createUserRequest)
        {
            User newUser = new User { Login = createUserRequest.Login, Password = createUserRequest.Password, RegistrationDate = DateTime.Now };

            await _dbContext.Users.AddAsync(newUser);
            await _dbContext.SaveChangesAsync();
            return new UserDto { Login = newUser.Login, Password = newUser.Password };
        }

        public async Task<UserDto?> Login(CreateUserRequest createUserRequest)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Login == createUserRequest.Login);
            if (user != null)
            {
                if (createUserRequest.Password == user.Password)
                {
                    return new UserDto { Id = user.UserId, Login = user.Login, Password = user.Password };
                }

                return null;
            }
            return null;
        }
    }
}
