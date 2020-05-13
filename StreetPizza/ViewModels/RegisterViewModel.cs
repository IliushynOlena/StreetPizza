using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StreetPizza.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Поле обов'язкове")]
        [EmailAddress(ErrorMessage = "Має бути пошта")]
        [Remote(action: "IsEmailInUse", controller: "Account")]

        public string Email { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,24}$",
           ErrorMessage = "Пароль має мати більше 6 символів і містити цифру, велику і малу літеру")]      
        public string Password { get; set; }

        [Required(ErrorMessage = "Поле обов'язкове")]
        [DataType(DataType.Password)]
        [Compare("Password", 
            ErrorMessage = "Пароль не співпадає")]
        public string ConfirmPassword { get; set; }

        public string Country { get; set; }
    }
}
