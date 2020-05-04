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
                Img = "1margarita.png",
                Ingredients = "Соус томатний, сир Моцарелла і свіжі томати",          
                PriceMedium = 125,
                PriceLarge = 175,
                IsFavorite = true
            });

            SeedProducts(context, new Product
            {
                Name = "Чотири сезона",
                Img = "pitstsa-chetyre-sezona.png",
                Ingredients = "Соус томатний, сир Моцарелла, стиглі томати, печериці," +
                " апетитна салямі, сир Дор Блю, що просто тане в роті.",
                PriceMedium = 155,
                PriceLarge = 255,
                IsFavorite = true
            });

            SeedProducts(context, new Product
            {
                Name = "Вегетеріанська",
                Img = "1vegetarianskaya.png",
                Ingredients = "Соус томатний, сир Моцарелла, печериці, стиглі томати, " +
                "солодкий перець, солодка кукурудза, маринований синій цибуля, маслини " +
                "і свіжа зелень.",
                PriceMedium = 159,
                PriceLarge = 259,
                IsFavorite = true
            });

            SeedProducts(context, new Product
            {
                Name = "Мюнхенська",
                Img = "myunhenskaya.png",
                Ingredients = "Гірчичний соус, сир моцарелла, апетитна салямі, " +
                "маринована цибуля, мисливські ковбаски а також копчене куряче філе, " +
                "трохи зелені і пікантне часникове масло.",
                PriceMedium = 169,
                PriceLarge = 269,
                IsFavorite = false
            });

            SeedProducts(context, new Product
            {
                Name = "Тревізо",
                Img = "trevizo.png",
                Ingredients = "Гірчичний соус, сир моцарелла, апетитна салямі, " +
                "свинина, мисливські ковбаски, стиглі томати, мариновані огірки, " +
                "гарячий гострий перець, трохи зелені і пікантне часникове масло.",
                PriceMedium = 169,
                PriceLarge = 269,
                IsFavorite = false
            });

            SeedProducts(context, new Product
            {
                Name = "Пеппероні",
                Img = "pepperoni.png",
                Ingredients = "Соус томатний, сир Моцарелла в поєднанні з ковбаскою Пепероні.",
                PriceMedium = 179,
                PriceLarge = 279,
                IsFavorite = false
            });

            SeedProducts(context, new Product
            {
                Name = "Сімейна",
                Img = "semeynaya.png",
                Ingredients = "Соус томатний, сир Моцарелла, соковита шинка, " +
                "солодка кукурудза, печериці, копчене куряче філе, свіжа зелень.",
                PriceMedium = 169,
                PriceLarge = 269,
                IsFavorite = false
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