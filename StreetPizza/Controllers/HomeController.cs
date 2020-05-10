using Microsoft.AspNetCore.Mvc;

namespace StreetPizza.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
