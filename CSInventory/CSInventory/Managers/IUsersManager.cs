using CSInventoryDatabase.Data;

namespace CSInventoryDatabase.Managers
{
    public interface IUsersManager
    {
        Task<List<UserDto>> Get();
        Task<UserDto> GetById(int id);
        Task<UserDto> CreateUser(CreateUserRequest createUserRequest);
        Task<UserDto> Login(Authorization data);

    }
}
