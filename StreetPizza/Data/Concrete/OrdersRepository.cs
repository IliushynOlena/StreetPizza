using StreetPizza.Data.Interfaces;
using StreetPizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.Data.Concrete
{
    public class OrdersRepository : IAllOrders
    {
        private readonly EFDbContext context;
        private readonly OrderCart orderCart;

        public OrdersRepository(EFDbContext context, OrderCart orderCart)
        {
            this.context = context;
            this.orderCart = orderCart;
        }
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            context.Order.Add(order);

            var items = orderCart.listOrderItems;

            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    ProductID = el.product.Id,
                    orderID = order.id,
                    price = el.product.PriceLarge
                };
                context.OrderDetail.Add(orderDetail);

            }
            context.SaveChanges();
           
        }
    }
}
