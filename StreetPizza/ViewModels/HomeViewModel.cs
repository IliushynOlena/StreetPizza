using StreetPizza.Data.Models;
using System.Collections.Generic;

namespace StreetPizza.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Product> FavoriteProducts { get; set; }
    }
}
