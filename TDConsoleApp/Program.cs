using System;

namespace TDConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            // Need to convert this to a method that creates a new instance
            // Ask user for fields.


            // Console UI
            // Add titles
            DisplayTitleUI();
            DisplayUserChoicesUI();


            // Give users a menu of what you want them to choose



            // You can use a do/while loop that keeps looping until
            // the user makes a choice to quit the program.





            // Certain choices will call different methods. i.e. Place an order, etc.
            // Place order









            //TacoOrder tacoCustomer1 = new("Angelina Jolie", TacoFilling.CarneAsada, TacoSide.BlackBeans, TacoSalsa.SalsaRoja);
            //Console.WriteLine(tacoCustomer1.displayTacoOrder());







        }

        private static void DisplayUserChoicesUI()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Please choose from these options: ");
            Console.WriteLine();
            Console.WriteLine("1. Place an order");
            Console.WriteLine("2. Show current order");
            Console.WriteLine("3. Contact us");
            Console.WriteLine("4. Quit");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;

            string userChoice;

            do
            {
                Console.Write("Choose an option number and press Enter: ");
                userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1": 
                        placeCustomerOrder();
                        break;
                    case "2": 
                        showCurrentOrder();
                        break;
                    case "3": 
                        Console.WriteLine("\nEmail us at customerservice@taqueriadigital.com");
                        break;
                    default:
                        Console.WriteLine("\nPlease make a valid choices.");
                        break;
                }
            } while (userChoice != "4");

            Console.WriteLine("\nThank you for your order!");
        }

        private static void showCurrentOrder()
        {
            throw new NotImplementedException();
        }

        private static void placeCustomerOrder()
        {
            throw new NotImplementedException();
        }

        private static void DisplayTitleUI()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****************************************");
            Console.WriteLine("****** Welcome to Taqueria Digital ******");
            Console.WriteLine("*****************************************");

            Console.WriteLine();            
        }
    }
}
