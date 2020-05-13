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

        public Product DeleteProduct(int Id)
        {
            Product prod = context.Products.Find(Id);
            if (prod != null)
            {
                context.Products.Remove(prod);
                context.SaveChanges();
            }
            return prod;
        }

        public Product GetProductById(int Id)
        {
            return context.Products.Find(Id);
        }
    }
}
