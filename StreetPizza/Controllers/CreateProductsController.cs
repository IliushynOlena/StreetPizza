using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StreetPizza.Data.Models;

namespace StreetPizza.Controllers
{
    public class CreateProductsController : Controller
    {
        
        public DbSet<Product> Products { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index([Bind] Product product)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                }
            }
            catch (Exception ex)
            {
                
            }
            return View();
        }
    }
    
}