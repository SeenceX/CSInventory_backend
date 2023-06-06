using System.ComponentModel.DataAnnotations;
namespace CSInventoryDatabase.Data
{
    public class CreateUserRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
