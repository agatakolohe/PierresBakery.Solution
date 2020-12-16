using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery
{
    public class Program
    {
        public static void Main()
        {
            string title = @" _____ _                    _       ____        _                   
|  __ (_)                  ( )     |  _ \      | |                  
| |__) |  ___ _ __ _ __ ___|/ ___  | |_) | __ _| | _____ _ __ _   _ 
|  ___/ |/ _ \ '__| '__/ _ \ / __| |  _ < / _` | |/ / _ \ '__| | | |
| |   | |  __/ |  | | |  __/ \__ \ | |_) | (_| |   <  __/ |  | |_| |
|_|   |_|\___|_|  |_|  \___| |___/ |____/ \__,_|_|\_\___|_|   \__, |
                                                               __/ |
                                                              |___/ 
";
            string bonAppetit = @" ____                                          _   _ _   _ 
|  _ \                  /\                    | | (_) | | |
| |_) | ___  _ __      /  \   _ __  _ __   ___| |_ _| |_| |
|  _ < / _ \| '_ \    / /\ \ | '_ \| '_ \ / _ \ __| | __| |
| |_) | (_) | | | |  / ____ \| |_) | |_) |  __/ |_| | |_|_|
|____/ \___/|_| |_| /_/    \_\ .__/| .__/ \___|\__|_|\__(_)
                             | |   | |                     
                             |_|   |_|                     
";

            Console.WriteLine(title);
            Console.WriteLine("Welcome to Pierre's Bakery!\n" + "------------------------------\n" + "Bread and pasteries baked fresh daily!\n" + "------------------------------\n" + "PRICES:\n" + "------------------------------\n" + "* Single loaf of bread: $5\n" + "* One pastry: $2\n" + "------------------------------\n" + "DEALS:\n" + "------------------------------\n" + "** BREAD: Buy 2, get 1 free.\n" + "** PASTRY: 3 for $5.\n" + "------------------------------\n" + "What kind of bread would you like?\n" + "Pumpernickle\n" + "Sour Dough\n" + "Rye\n" + "Ciabatta");
            string breadType = Console.ReadLine();
            Console.WriteLine("Enter the number of loaves of bread you would like.");
            int breadQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of pasteries would like.");
            int pastryQuantity = int.Parse(Console.ReadLine());
            Bread userBread = new Bread(breadQuantity, breadType);
            Pastry userPastry = new Pastry(pastryQuantity);
            int totalCost = userBread.BreadCost() + userPastry.PastryCost();
            Console.WriteLine("*** Receipt ***\n" + "------------------------------\n" + "BREAD:\n" + "------------------------------\n" + breadQuantity + " loaves of " + breadType + " bread\n" + "------------------------------\n" + "PASTRY:\n" + "------------------------------\n" + pastryQuantity + " pasteries\n" + "------------------------------\n" + "** TOTAL **\n" + "------------------------------\n" + "$" + totalCost + "\nThank you for ordering from Pierre's Bakery! Enjoy your baked goodies!");
            Console.WriteLine("Would you like to order again? ['Y' for yes, 'Enter' for no]");
            string userResponse = Console.ReadLine();
            if (userResponse == "y" || userResponse == "Y")
            {
                Main();
            }
            else
            {
                Console.WriteLine(bonAppetit);
            }
        }
    }
}




