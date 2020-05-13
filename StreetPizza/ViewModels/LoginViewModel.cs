using System.ComponentModel.DataAnnotations;

namespace StreetPizza.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Поле обов'язкове")]
        [EmailAddress(ErrorMessage = "Має бути пошта")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
