using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    class Menu
    {
        public static void ShowMenu()
        {
            Console.WriteLine("* ** *** Welcome to the Vending Machine 2000! *** ** *");

            // Menu
            Console.WriteLine("1. Insert money");
            Console.WriteLine("2. Return money\n");
            Console.WriteLine("============================================");
            Console.WriteLine("\tProducts");
            Console.WriteLine("============================================");
            Console.WriteLine("\tBeverages");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\t3. SvampZoda\t\t\t5");
            Console.WriteLine("\t4. Loka Gul Snö\t\t\t6");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\tFoods");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\t5. Spam-wich\t\t\t25");
            Console.WriteLine("\t6. Egg-Bacon-Spam-wich\t\t30");
            Console.WriteLine("\t7. Spam-spam-spam-bacon-spam\t55");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\tSnacks");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("\t8. Crunchy Frog Chocolate\t10");
            Console.WriteLine("\t9. Spring Surprise Chocolate\t15");
            Console.WriteLine("\t10. R U Nuts\t\t\t20");

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
        }
    }
}
