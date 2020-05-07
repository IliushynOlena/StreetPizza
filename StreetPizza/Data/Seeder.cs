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
                IsFavorite = true,
                Category = "Pizza"
            });

            SeedProducts(context, new Product
            {
                Name = "Чотири сезона",
                Img = "pitstsa-chetyre-sezona.png",
                Ingredients = "Соус томатний, сир Моцарелла, стиглі томати, печериці," +
                " апетитна салямі, сир Дор Блю, що просто тане в роті.",
                PriceMedium = 155,
                PriceLarge = 255,
                IsFavorite = true,
                Category = "Pizza"
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
                IsFavorite = true,
                Category = "Pizza"
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
                IsFavorite = false,
                Category = "Pizza"
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
                IsFavorite = false,
                Category = "Pizza"
            });

            SeedProducts(context, new Product
            {
                Name = "Пеппероні",
                Img = "pepperoni.png",
                Ingredients = "Соус томатний, сир Моцарелла в поєднанні з ковбаскою Пепероні.",
                PriceMedium = 179,
                PriceLarge = 279,
                IsFavorite = false,
                Category = "Pizza"
            });

            SeedProducts(context, new Product
            {
                Name = "Сімейна",
                Img = "semeynaya.png",
                Ingredients = "Соус томатний, сир Моцарелла, соковита шинка, " +
                "солодка кукурудза, печериці, копчене куряче філе, свіжа зелень.",
                PriceMedium = 169,
                PriceLarge = 269,
                IsFavorite = false,
                Category = "Pizza"
            });
            #endregion

            #region tblProducts - Сендвічі
            SeedProducts(context, new Product
            {
                Name = "Сендвіч з шинкою",
                Img = "sendvich-s-vetchinoy.png",
                Ingredients = "Хрустка чіабатта, ніжний соус цезар, свіжий огірок, " +
                "стиглі томати, маринована синя цибуля, соковита шинка, мікс салату",
                PriceLarge = 85,
                IsFavorite = false,
                Category = "Sandwich"
            });

            SeedProducts(context, new Product
            {
                Name = "Сендвіч з салямі",
                Img = "sendvich-s-salyami.jpg",
                Ingredients = "Хрустка чіабатта, ніжний вершковий сир, свіжий огірок, " +
                "стиглі томати, маринована синя цибуля, апетитна салямі, мікс салату",
                PriceLarge = 85,
                IsFavorite = false,
                Category = "Sandwich"
            });

            SeedProducts(context, new Product
            {
                Name = "Сендвіч з куркою",
                Img = "sendvich-s-kuritsey.jpg",
                Ingredients = "Хрустка чіабатта, ніжний вершковий сир, свіжий огірок, " +
               "стиглі томати, маринована синя цибуля, апетитна салямі, мікс салату",
                PriceLarge = 89,
                IsFavorite = false,
                Category = "Sandwich"
            });

            SeedProducts(context, new Product
            {
                Name = "Сендвіч з лососем",
                Img = "sendvich-s-lososem.jpg",
                Ingredients = "Хрустка чіабатта, сирний соус, свіжий огірок, " +
                "стиглі томати, маринована синя цибуля, копчений лосось, мікс салату",
                PriceLarge = 109,
                IsFavorite = false,
                Category = "Sandwich"
            });
            #endregion

            #region tblProducts - Суші
            SeedProducts(context, new Product
            {
                Name = "Капа Макі",
                Img = "kapa-maki.png",
                Ingredients = "Рис, норі, свіжий огірок і кунжут",
                PriceLarge = 39,
                IsFavorite = false,
                Category = "Sushi"
            });
            SeedProducts(context, new Product
            {
                Name = "Макі авокадо",
                Img = "maki-avokado.jpg",
                Ingredients = "Рис, норі, стиглий авокадо в поєднанні з соусом Унагі і кунжутом",
                PriceLarge = 49,
                IsFavorite = false,
                Category = "Sushi"
            });
            SeedProducts(context, new Product
            {
                Name = "Кунсей макі",
                Img = "kunsey-maki.jpg",
                Ingredients = "Рис, норі з копченим лососем",
                PriceLarge = 69,
                IsFavorite = false,
                Category = "Sushi"
            });
            SeedProducts(context, new Product
            {
                Name = "Сяке макі",
                Img = "syake-maki.jpg",
                Ingredients = "Рис, норі з ніжним лососем",
                PriceLarge = 69,
                IsFavorite = false,
                Category = "Sushi"
            });
            SeedProducts(context, new Product
            {
                Name = "Унагі макі",
                Img = "unagi-maki.jpg",
                Ingredients = "Рис, норі, пікантний вугор в поєднанні з соусом Унагі і кунжут",
                PriceLarge = 99,
                IsFavorite = false,
                Category = "Sushi"
            });
            SeedProducts(context, new Product
            {
                Name = "Філадельфія",
                Img = "filadelfiya.png",
                Ingredients = "Рис, норі з ніжним лососем, свіжим огірком та сиром Філадельфія",
                PriceLarge = 125,
                IsFavorite = false,
                Category = "Sushi"
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