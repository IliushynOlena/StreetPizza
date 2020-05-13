using Microsoft.AspNetCore.Mvc;
using StreetPizza.Data.Interfaces;
using StreetPizza.Data.Models;
using StreetPizza.ViewModels;
using System.Linq;

namespace StreetPizza.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _repository;
        public HomeController(IProductRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            HomeViewModel model = new HomeViewModel
            {
                FavoriteProducts = _repository.Products
                .Where(p => p.IsFavorite == true)
                .Take(3),

                Products = _repository.Products
                .Take(8)
            };

            return View(model);
        }
    }
}
