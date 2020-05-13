using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StreetPizza.Data.Interfaces;
using StreetPizza.Data.Models;
using StreetPizza.ViewModels;

namespace StreetPizza.Controllers
{
    public class CreateProductsController : Controller
    {

        private IProductRepository _prodRep;
        private IHostingEnvironment hostingEnvironment;
        public CreateProductsController(IProductRepository postRep, IHostingEnvironment hostingEnvironment)
        {
            _prodRep = postRep;
            this.hostingEnvironment = hostingEnvironment;
        }

        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateProduct(CreateProductsViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqFileName = null;
                if (model.Img != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/pizza");
                    uniqFileName = Guid.NewGuid().ToString() + "_" + model.Img.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqFileName);
                    model.Img.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                else
                {
                    uniqFileName = "no.jpg";
                }
                Product newProduct = new Product
                {
                    Category = model.Category,
                    Name = model.Name,
                    Ingredients = model.Ingredients,
                    PriceLarge = Convert.ToUInt16(model.PriceLarge),
                    Img = uniqFileName
                };
                _prodRep.CreateProducts(newProduct);

                return RedirectToRoute("default", new { controller = "Menu", action = "Index" });

            }
            return View();

        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var prod = _prodRep.GetProductById(id);
            if (prod.Img != null && prod.Img != "no.png")
            {
                //видаляємо фото з папки wwwroot по заданому шляху
                string filePath = Path.Combine(hostingEnvironment.WebRootPath, "img/pizza", prod.Img);
                System.IO.File.Delete(filePath);
            }
            //видаляємо дані з бази по id
            _prodRep.DeleteProduct(id);
            //редірект 
            return RedirectToRoute("default", new { controller = "Menu", action = "Index" });

        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            Product prod = _prodRep.GetProductById(id);
            EditViewModel editViewModel = new EditViewModel
            {
                Id = prod.Id,
                Category = prod.Category,
                Name = prod.Name,
                Ingredients = prod.Ingredients,
                PriceLarge = prod.PriceLarge.ToString(),
                ExistImgPath = prod.Img
            };
            return View(editViewModel);
        }

        [HttpPost]
        public IActionResult Edit(EditViewModel model)
        {

            if (ModelState.IsValid)
            {
                Product prod = _prodRep.GetProductById(model.Id);
                prod.Category = model.Category;
                prod.Name = model.Name;
                prod.Ingredients = model.Ingredients;
                prod.PriceLarge = Convert.ToUInt16(model.PriceLarge);

                if (model.Img != null)
                {
                    if (model.ExistImgPath != null)
                    {
                        string filePath = Path.Combine(hostingEnvironment.WebRootPath, "img/pizza", model.ExistImgPath);
                        System.IO.File.Delete(filePath);
                    }
                    prod.Img = UploadedFile(model);
                }

                _prodRep.UpdateProduct(prod);
                return RedirectToRoute("default", new { controller = "Menu", action = "Index" });
            }
            return View();
        }

        private string UploadedFile(EditViewModel model)
        {
            string uniqFileName = null;
            if (model.Img != null)
            {
                string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "img/pizza");
                uniqFileName = Guid.NewGuid().ToString() + "_" + model.Img.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Img.CopyTo(fileStream);
                }
            }

            return uniqFileName;
        }
    }
    
}