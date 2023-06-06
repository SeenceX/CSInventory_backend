using CSInventoryDatabase.Data;

namespace CSInventoryDatabase.Managers
{
    public interface IUsersManager
    {
        Task<List<UserDto>> Get();
        Task<UserDto> GetById(int id);
        Task<UserDto> Registration(CreateUserRequest createUserRequest);
        Task<UserDto> Login(CreateUserRequest createUserRequest);
    }
}
