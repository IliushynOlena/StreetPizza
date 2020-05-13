using StreetPizza.Data.Models;
using System.Collections.Generic;

namespace StreetPizza.Data.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        Product CreateProducts(Product prod);
        Product GetProductById(int id);
        Product DeleteProduct(int id);
        Product UpdateProduct(Product prod);

    }
}
