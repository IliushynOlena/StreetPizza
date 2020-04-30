using Microsoft.EntityFrameworkCore;
using StreetPizza.Data.Models;

namespace StreetPizza.Data
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
