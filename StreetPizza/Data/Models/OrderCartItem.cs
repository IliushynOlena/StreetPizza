using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.Data.Models
{
    public class OrderCartItem
    {
        public int id { get; set; }
        public Product product { get; set; }
        public int price { get; set; }
        public string OrderCartId { get; set; }
    }
}
