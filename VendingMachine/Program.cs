using System;

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
            

            //Val av produkter

            // Visa Varukorg

            //Återbetalning av överskjutande medel
        }

        
    }
}
