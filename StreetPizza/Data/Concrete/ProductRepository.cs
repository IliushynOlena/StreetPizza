using StreetPizza.Data.Interfaces;
using StreetPizza.Data.Models;
using System.Collections.Generic;

namespace StreetPizza.Data.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private EFDbContext context;
        public ProductRepository(EFDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Product> Products
        {
            get { return context.Products; }
        }

        public Product CreateProducts(Product prod)
        {
            context.Products.Add(prod);
            context.SaveChanges();
            return prod;
        }
    }
}
