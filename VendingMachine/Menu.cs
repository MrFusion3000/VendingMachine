using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Menu
    {
        //public int CustomerWallet = 0;

        public int CustomerWallet { get; set; }
        public static void ShowMenu()
        {
            Console.WriteLine("**  Welcome to the Vending Machine 2000 ! **");
            Console.WriteLine("--------------------------------------------");

            // Menu
            Console.WriteLine("1. Insert money");
            Console.WriteLine("2. Show Cart");
            Console.WriteLine("3. Finish purchase/Return money");

            Console.WriteLine("============================================");
            Console.WriteLine("\tProducts");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\tBeverages");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\t4. ZvampZoda\t\t\t5");
            Console.WriteLine("\t5. Loka Gul Snö\t\t\t6");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\tFoods");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\t6. Spam-wich\t\t\t25");
            Console.WriteLine("\t7. Egg-Bacon-Spam-wich\t\t30");
            Console.WriteLine("\t8. Spam-spam-spam-bacon-spam\t55");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\tSnacks");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\t9. Crunchy Frog Chocolate\t10");
            Console.WriteLine("\t10. Spring Surprise Chocolate\t15");
            Console.WriteLine("\t11. R U Nuts\t\t\t20\n");
            Console.WriteLine("\tENTER to Exit");
            Console.WriteLine("--------------------------------------------");

        }
    }
}
