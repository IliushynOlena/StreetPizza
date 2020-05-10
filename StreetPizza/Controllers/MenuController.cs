using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StreetPizza.Data.Interfaces;
using StreetPizza.Data.Models;
using StreetPizza.ViewModels;

namespace StreetPizza.Controllers
{
    [Authorize]
    public class MenuController : Controller
    {

        // НІЧОГО НЕ МІНЯТИ В ЦЬОМУ КОНТРОЛЕРІ!!!
        // НІЧОГО НЕ МІНЯТИ В ЦЬОМУ КОНТРОЛЕРІ!!!
        // НІЧОГО НЕ МІНЯТИ В ЦЬОМУ КОНТРОЛЕРІ!!!

        private readonly IProductRepository _repository;
        public int PageSize = 3;
        public MenuController(IProductRepository repository)
        {
            _repository = repository;
        }
        public ViewResult Index(string category, int productPage = 1)
            => View(new ProductListViewModel
            {
                Products = _repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.Id)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),

                PaggingInfo = new PaggingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = (category == null) ?
                    _repository.Products.Count() :
                    _repository.Products.Where(p =>
                        p.Category == category).Count()
                },

                CurrentCategory = category
            });
    }
}