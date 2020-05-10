using System.ComponentModel.DataAnnotations;

namespace StreetPizza.ViewModels
{
    public class CreateRoleViewModel
    {
        [Required]
        public string RoleName { get; set; }
    }
}
