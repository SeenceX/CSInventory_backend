using CSInventoryDatabase.Data;
using CSInventoryDatabase.Database;
using Microsoft.EntityFrameworkCore;

namespace CSInventoryDatabase.Managers
{
    public class UsersManager : IUsersManager
    {
        private readonly UsersContext _dbContext;
        public UsersManager(UsersContext dbContext)
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
            if (user != null)
            {
                return new UserDto { Id = user.UserId, Login = user.Login, Password = user.Password };
            }
            else
            {
                return null;
            }
        }
        public async Task<UserDto> CreateUser(CreateUserRequest createUserRequest)
        {
            User newUser = new User { Login = createUserRequest.Login, Password = createUserRequest.Password, RegistrationDate = DateTime.Now };

            _dbContext.Users.Add(newUser);
            await _dbContext.SaveChangesAsync();
            return new UserDto { Login = newUser.Login, Password = newUser.Password };
        }

        public async Task<UserDto?> Login(Authorization data)
        {
            var user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Login == data.Login);
            if (user != null)
            {
                if (data.Password == user.Password)
                {
                    return new UserDto { Id = user.UserId, Login = user.Login, Password = user.Password };
                }

                return null;
            }
            else
            {
                return null;
            }
        }
    }
}
