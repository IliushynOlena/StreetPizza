using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StreetPizza.Data.Concrete;
using StreetPizza.Data.Interfaces;
using StreetPizza.Data.Models;
using StreetPizza.ViewModels;

namespace StreetPizza.Controllers
{
    public class OrderCartController : Controller
    {
        private readonly IProductRepository _produductRepository;

        private readonly OrderCart _orderCart;

        public OrderCartController(IProductRepository productRepository, OrderCart orderCart)
        {
            _produductRepository = productRepository;
            _orderCart = orderCart;
        }

        public ViewResult Index()
        {
            var items = _orderCart.getOrderItems();
            _orderCart.listOrderItems = items;

            var obj = new OrderCartViewModel
            {
                orderCart = _orderCart
               };

            ViewBag.TotalSum = _orderCart.CalculateTotalValue();
           return View(obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _produductRepository.Products.FirstOrDefault(i => i.Id == id);
            if(item!=null)
            {
                _orderCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
     
    }
}