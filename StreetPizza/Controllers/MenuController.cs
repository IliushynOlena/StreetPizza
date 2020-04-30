using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StreetPizza.Data.Interfaces;
using StreetPizza.Data.Models;

namespace StreetPizza.Controllers
{
    public class MenuController : Controller
    {
        private readonly IProductRepository _repository;
        public MenuController(IProductRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            List<Product> Products = _repository.Products.ToList();
            return View(Products);
        }
    }
}