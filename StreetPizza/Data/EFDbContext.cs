using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StreetPizza.Data.Models;
using System.Linq;

namespace StreetPizza.Data
{
    public class EFDbContext : IdentityDbContext<ApplicationUser>
    {
        public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Встановлюємо опцію видалення по foreignKey - Restrict
            // Забороняємо видалення, якщо дані звязані по foreignKey
            foreach (var foreignKey in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetForeignKeys()))
            {
                foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }
    }
}
