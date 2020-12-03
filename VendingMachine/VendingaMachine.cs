using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{ 
    class VendingMachine : VendingMachineBaseClass 
    {
        public override void AddToCustomerWallet(int moneyInput) 
        {
            int MoneyInput = moneyInput;
            CustomerWallet += MoneyInput;
        }
        public override void SubFromCustomerWallet(int moneyInput) 
        {
            int MoneyInput = moneyInput;
            CustomerWallet -= MoneyInput;
        }
        public override void AddToShoppingCart() { }
        public override void SubFromShoppingCart() { }

        public void VendingMachineSetup()
        {

        }
        //public void VendingMachineBaseClass(int vendingMachineId)
        //{
        //    VendingMachineId = vendingMachineId;
            //List<ProductList> = new List<Product>();
        //}

        public static int CustomerInput()
        {
            //Inmatning av pengar
            int[] moneyArray = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };

            bool insert = true;
            int CustomerWallet = 0;
            while (insert)
            {
                Console.WriteLine("Insert money (ENTER to stop)");
                string inputText = Console.ReadLine();                

                insert = int.TryParse(inputText, out int inputMoney);

                if (string.IsNullOrWhiteSpace(inputText))
                { insert = false; }

                if (insert == true)
                {
                int first = Array.Find(moneyArray, p => p.Equals(inputMoney));

                    if (first == inputMoney)
                    {
                        CustomerWallet += inputMoney;
                    }
                    else
                    {
                        Console.WriteLine("Not a valid denomination!");
                    }
                }
                else
                {
                    Console.WriteLine("Returning to menu!");
                }
                              
            }

            return CustomerWallet;
        }
    }

        //List of products, array of products or list of enums    

    

}

