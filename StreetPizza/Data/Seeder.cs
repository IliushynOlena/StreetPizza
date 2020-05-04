using StreetPizza.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreetPizza.Data
{
    public class Seeder
    {
        public static void SeedData(EFDbContext context)
        {
            #region tblProducts - Піци
            SeedProducts(context, new Product
            {
                Name = "Маргарита",
                Img = "1margarita.jpg",
                Ingredients = "Помідори, томатний соус, моцарелла, базилік",          
                PriceMedium = 125,
                PriceLarge = 175,
                IsFavorite = true
            });

            SeedProducts(context, new Product
            {
                Name = "Чотири сезона",
                Img = "pitstsa-chetyre-sezona.jpg",
                Ingredients = "Помідори, печериці, салямі, сир Дор Блю, моцарелла, томатний соус",
                PriceMedium = 155,
                PriceLarge = 255,
                IsFavorite = true
            });

            SeedProducts(context, new Product
            {
                Name = "Вегетеріанська",
                Img = "1vegetarianskaya.jpg",
                Ingredients = "Помідори, печериці, моцарелла, солодкий перець, " +
                "кукурудза, маслини, маринована синя цибуля, томатний соус, свіжа зелень",
                PriceMedium = 159,
                PriceLarge = 259,
                IsFavorite = true
            });

            #endregion
        }

        public static void SeedProducts(EFDbContext context, Product model)
        {
            var product = context.Products.SingleOrDefault(t => t.Name == model.Name);
            if (product == null)
            {
                product = new Product
                {
                    Id = model.Id,
                    Name = model.Name,
                    Img = model.Img,
                    Ingredients = model.Ingredients,
                    PriceMedium = model.PriceMedium,
                    PriceLarge = model.PriceLarge,
                    IsFavorite = model.IsFavorite

                };
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
    }
}