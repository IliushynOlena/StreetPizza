using Microsoft.AspNetCore.Mvc;
using StreetPizza.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.Components
{
    public class CategoriesMenuViewComponent : ViewComponent
    {
        private IProductRepository repository;
        public CategoriesMenuViewComponent(IProductRepository repository)
        {
            this.repository = repository;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
