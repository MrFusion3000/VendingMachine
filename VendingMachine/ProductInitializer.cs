using System;
using System.Collections.Generic;

namespace VendingMachine
{
    public class ProductInitializer
    {
        //Add Product inventory
        public static void ProductInit()
        {
            Beverage ZvampZoda = new Beverage
            {
                ProductName = "ZvampZoda",
                Price = 6,
                Description = "A fine sparkling soda made of fresh forest mushrooms."
            };

            Beverage Loka = new Beverage
            {
                ProductName = "Loka Gul Snö",
                Price = 5,
                Description = "A less than tasty sparkling soda made of yellow snow."
            };

            Food Spamwich = new Food
            {
                ProductName = "SPAM-wich",
                Price = 25,
                Description = "It's like a sandwich, but with SPAM."
            };

            Food EggBaconSpamwich = new Food
            {
                ProductName = "Egg-Bacon-Spam-wich",
                Price = 30,
                Description = "It's like a SPAM-wich, but also with egg and bacon ."
            };

            Food Spamspamspambaconspam = new Food
            {
                ProductName = "Spam-spam-spam-bacon-spam",
                Price = 30,
                Description = "It's not like a SPAM-wich, only Spam, Spam, Spam, bacon and Spam."
            };

            Snacks CrunchyFrog = new Snacks
            {
                ProductName = "Cruchy Frog Chocolate",
                Price = 10,
                Description = "Freshly picked in the morning and gently washed in morning dew."
            };

            Snacks SpringSurprise = new Snacks
            {
                ProductName = "Spring Surprise Chocolate",
                Price = 15,
                Description = "Delicious Belgian chocolate with two steel springs piercing through..."
            };

            Snacks RuNuts = new Snacks
            {
                ProductName = "R U Nuts Nuts",
                Price = 20,
                Description = "They'll make you crazy, put you in a frenzy!"
            };

            List<ProductItem> inventory = new List<ProductItem>
            {
                ZvampZoda,
                Loka,
                Spamwich,
                EggBaconSpamwich,
                Spamspamspambaconspam,
                CrunchyFrog,
                SpringSurprise,
                RuNuts
            };

            //List<ProductItem> shoppingCart = new List<ProductItem>();

            //foreach (var item in inventory)
            //{
            //    Console.WriteLine($"item: {item.ProductName}\tPrice: {item.Price}\tDescription: {item.Description}");
            //}
        }


}
}
