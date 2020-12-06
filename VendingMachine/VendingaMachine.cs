using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VendingMachine
{ 
    class VendingMachine : VendingMachineBaseClass 
    {
        public static bool insert { get; private set; }

        //public override void AddToCustomerWallet(int moneyInput) 
        //{
        //    int MoneyInput = moneyInput;
        //    CustomerWallet += MoneyInput;
        //}
        //public override void SubFromCustomerWallet(int moneyInput) 
        //{
        //    int MoneyInput = moneyInput;
        //    CustomerWallet -= MoneyInput;
        //}
        //public override void AddToShoppingCart() { }
        //public override void SubFromShoppingCart() { }

        public void VendingMachineSetup()
        {
        }

        public static void MenuChoices()
        {
            Console.Clear();

            insert = true;

            while (insert)
            {
                Menu.ShowMenu();
                Console.WriteLine("Your wallet contains: {0}", CustomerWallet);
                Console.WriteLine("--------------------------------------------");
                Console.Write("Make your choice (1-9, ENTER to leave): ");

                string inputText = Console.ReadLine();

                insert = int.TryParse(inputText, out int menuChoice);

                switch (menuChoice)
                {
                    case 1:
                        CustomerWallet = VendingMachine.CustomerInput();
                        break;
                    case 2:
                        ShowShoppingCart();
                        break;
                    case 3:
                        FinishPurchase();
                        break;
                    case 4:
                        ProductChoice = ProductInit.ZvampZoda;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 5:
                        ProductChoice = ProductInit.Loka;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 6:
                        ProductChoice = ProductInit.Spamwich;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 7:
                        ProductChoice = ProductInit.EggBaconSpamwich;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 8:
                        ProductChoice = ProductInit.Spamspamspambaconspam;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 9:
                        ProductChoice = ProductInit.CrunchyFrog;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 10:
                        ProductChoice = ProductInit.SpringSurprise;
                        CheckValidPurchase(ProductChoice);
                        break;
                    case 11:
                        ProductChoice = ProductInit.RuNuts;
                        CheckValidPurchase(ProductChoice);
                        break;
                    default:
                        insert = false;
                        break;
                }
            }
        }


public static int CustomerInput()
        {
            Console.Clear();
            Console.WriteLine(" Insert money\n");

            //Inmatning av pengar
            int[] moneyArray = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

            bool insert = true;
            //int CustomerWallet = 0;
            while (insert)
            {
                Console.WriteLine("Insert money (ENTER to stop)");
                string inputText = Console.ReadLine();                

                insert = int.TryParse(inputText, out int inputMoney);

                if (string.IsNullOrWhiteSpace(inputText))
                {
                    //FinishPurchase();
                    insert = false; 
                }

                if (insert == true)
                {
                int first = Array.Find(moneyArray, p => p.Equals(inputMoney));

                    if (first == inputMoney)
                    {
                        CustomerWallet += inputMoney;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid value!");
                    }
                }
                else
                {
                    Console.WriteLine("Returns to menu!");
                }                              
            }
            return CustomerWallet;
        }

        static void CheckValidPurchase(ProductItem productChoice)
        {
            ProductItem ProductChoice = productChoice;

            if (CustomerWallet < productChoice.Price)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nNo can do! Price is {0} and you have {1} in your wallet.\n", ProductChoice.Price, CustomerWallet);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                shoppingCart.Add(ProductChoice);
                var shoppingItem = shoppingCart.Last().ProductName;
                Console.WriteLine("You added a {0}\n", shoppingItem);
                CustomerWallet -= ProductChoice.Price;
                Console.ReadKey();
                Console.Clear();
            }
        }

        public static void ShowShoppingCart()
        {
            Console.Clear();
            Console.WriteLine("Your shopping cart contains the following items:\n");
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"\nCart item: {item.ProductName}\tPrice: {item.Price}\nDescription: {item.Description}\n");
            }
            Console.ReadKey();
            Console.Clear();
        }

        public static bool FinishPurchase()
        {
            foreach (var item in shoppingCart)
            {
                Console.WriteLine($"Cart item: {item.ProductName}\tPrice: {item.Price}\nDescription: {item.Description}\n\n");
            if (item is Beverage) 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Beverage.Use(item.ProductName) ;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n");
                }
                if (item is Food)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Food.Use(item.ProductName);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n");

                }
                if (item is Snacks)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Snacks.Use(item.ProductName);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("\n");
                }
            }

            Console.WriteLine("Here's your change! {0}", CustomerWallet);

            return insert = false;
        }

    }

}

