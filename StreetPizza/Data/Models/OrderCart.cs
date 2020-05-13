using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.Data.Models
{
    public class OrderCart
    {
        private EFDbContext context;
        public OrderCart(EFDbContext context)
        {
            this.context = context;
        }
        public string OrderCartId { get; set; }
        public List<OrderCartItem> listOrderItems { get; set; }

        //додає товар в корзину по типу
        public static OrderCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var content = services.GetService<EFDbContext>();
            string orderCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", orderCartId);
            return new OrderCart(content) { OrderCartId = orderCartId };
        }

        //додаэ всы товари в корзину
        public void AddToCart(Product product)
        {
            context.OrderCartItem.Add(new OrderCartItem
            {
                OrderCartId = OrderCartId,
                product = product,
                price = product.PriceLarge
            });

            context.SaveChanges();
        }

        public List<OrderCartItem> getOrderItems()
        {
            return context.OrderCartItem.Where(c => c.OrderCartId == OrderCartId).Include(s => s.product).ToList();
        }

        //отримуємо загальну суму товарів в кошику
        public decimal CalculateTotalValue()
        {
            return getOrderItems().Sum(p => p.price);
        }
    }
}
