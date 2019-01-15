using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var grad = Console.ReadLine();
            var kol = double.Parse(Console.ReadLine());
            double price = 0;

            if(grad == "Sofia")
            {
                switch(product)
                {
                    case "coffee": price = .50; break;
                    case "water": price = .80; break;
                    case "beer": price = 1.20; break;
                    case "sweets": price = 1.45; break;
                    case "peanuts": price = 1.60; break;
                }
            }

            if (grad == "Plovdiv")
            {
                switch (product)
                {
                    case "coffee": price = .40; break;
                    case "water": price = .70; break;
                    case "beer": price = 1.15; break;
                    case "sweets": price = 1.30; break;
                    case "peanuts": price = 1.50; break;
                }
            }

            if (grad == "Varna")
            {
                switch (product)
                {
                    case "coffee": price = .45; break;
                    case "water": price = .70; break;
                    case "beer": price = 1.10; break;
                    case "sweets": price = 1.35; break;
                    case "peanuts": price = 1.55; break;
                }
            }

            Console.WriteLine(kol * price);
        }
    }
}
