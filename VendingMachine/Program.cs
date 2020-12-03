using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main()
        {
            Menu.ShowMenu();

            bool insert = true;
            int CustomerWallet = 0;

            while (insert)
            {
                Console.WriteLine("Make your choice (1-9, ENTER to leave):");
                string inputText = Console.ReadLine();

                insert = int.TryParse(inputText, out int menuChoice);
                
                switch (menuChoice)
                {
                    case 1:
                        CustomerWallet = VendingMachine.CustomerInput();
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                    case 7:
                        break;
                    case 8:
                        break;
                    case 9:
                        break;
                    case 10:
                        break;
                    default:
                        insert = false;
                        break;
                }                
            }
            
            Console.WriteLine("Your wallet contains: {0}", CustomerWallet);

            //ProductItem.InitProducts();
            
            //Add Drink SvampZoda
            Beverage Zvampsoda = new Beverage()
            {
                ProductName = "ZvampZoda",
                Price = 6,
                Description = "A fine sparkling soda made of fresh forest mushrooms."
            };

            Beverage Loka = new Beverage()
            {
                ProductName = "Loka Gul Snö",
                Price = 5,
                Description = "A less than tasty sparkling soda made of yellow snow."
            };

            Food Spamwich = new Food()
            {
                ProductName = "SPAM-wich",
                Price = 25,
                Description = "It's like a sandwich, but with SPAM."
            };

            Food EggBaconSpamwich = new Food()
            {
                ProductName = "Egg-Bacon-Spam-wich",
                Price = 30,
                Description = "It's like a SPAM-wich, but also with egg and bacon ."
            };

            Food Spamspamspambaconspam = new Food()
            {
                ProductName = "Spam-spam-spam-bacon-spam",
                Price = 30,
                Description = "It's not like a SPAM-wich, only Spam, Spam, Spam, bacon and Spam."
            };

            List<ProductItem> inventory = new List<ProductItem>();

            List<ProductItem> shoppingCart = new List<ProductItem>();

            inventory.Add(Zvampsoda);
            inventory.Add(Loka);
            inventory.Add(Spamwich);
            inventory.Add(EggBaconSpamwich);
            inventory.Add(Spamspamspambaconspam);




            Console.WriteLine("Bought: " + Spamwich.ProductName + " for " + Spamwich.Price + " Info:" + Spamwich.Description );

            //inventory.Add(new Beverage(drink));


            



            //shoppingCart.Add(new ProductItem(drink)); 



            //Val av produkter

            // Visa Varukorg

            //Återbetalning av överskjutande medel
        }

        
    }
}
