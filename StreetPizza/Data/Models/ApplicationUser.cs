using Microsoft.AspNetCore.Identity;

namespace StreetPizza.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Country { get; set; }
    }
}
