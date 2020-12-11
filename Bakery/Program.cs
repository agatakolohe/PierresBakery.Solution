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
            Console.WriteLine(title);
            Console.WriteLine("Welcome to Pierre's Bakery!\n" + "Bread and pasteries baked fresh daily!\n" + "PRICES:\n" + "* Single loaf of bread: $5\n" + "* One pastry: $2\n" + "Our deals today include:\n" + "** BREAD: Buy 2, get 1 free.\n" + "** PASTRY: 3 for $5.\n" + "Enter the number of loaves of bread you would like.");
            int breadQuantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of pasteries would like.");
            int pastryQuantity = int.Parse(Console.ReadLine());
            Bread userBread = new Bread(breadQuantity);
            Pastry userPastry = new Pastry(pastryQuantity);
            int totalCost = userBread.BreadCost() + userPastry.PastryCost();
            Console.WriteLine("*** Receipt ***\n" + "BREAD:\n" + breadQuantity + " loaves of bread\n" + "PASTRY:\n" + pastryQuantity + " pasteries\n" + "** TOTAL **\n" + "$" + totalCost + "\n Thank you for ordering from Pierre's Bakery! Enjoy your baked goodies!");
            string bonAppetit = @" ____                                          _   _ _   _ 
|  _ \                  /\                    | | (_) | | |
| |_) | ___  _ __      /  \   _ __  _ __   ___| |_ _| |_| |
|  _ < / _ \| '_ \    / /\ \ | '_ \| '_ \ / _ \ __| | __| |
| |_) | (_) | | | |  / ____ \| |_) | |_) |  __/ |_| | |_|_|
|____/ \___/|_| |_| /_/    \_\ .__/| .__/ \___|\__|_|\__(_)
                             | |   | |                     
                             |_|   |_|                     
";
            Console.WriteLine(bonAppetit);

        }

    }
}




