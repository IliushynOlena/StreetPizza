using Microsoft.AspNetCore.Mvc;
using StreetPizza.Data.Interfaces;
using StreetPizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly OrderCart orderCart;

        public OrderController(IAllOrders allOrders, OrderCart orderCart)
        {
            this.allOrders = allOrders;
            this.orderCart = orderCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            orderCart.listOrderItems = orderCart.getOrderItems();

            if(orderCart.listOrderItems.Count==0)
            {
                ModelState.AddModelError("", "Немає товарів у корзині!");
            }

            if(ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View();
        }

        public IActionResult Complete()
        {
            ViewBag.Message = "Замовлення успішно опрацьовано";
            return View();
        }

    }
}
