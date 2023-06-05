using System.ComponentModel.DataAnnotations;
namespace CSInventoryDatabase.Data
{
    public class CreateUserRequest
    {
        public string Login { get; set; }
        public string Password { get; set; }
    }
    public class Authorization
    {
        [Display(Name = "Имя пользователя")]
        [Required(ErrorMessage = "Нужно ввести имя пользователя")]
        public string Login { get; set; }
        [Display(Name = "Введите пароль")]
        [Required(ErrorMessage = "Нужно ввести пароль")]
        public string Password { get; set; }
    }

}
