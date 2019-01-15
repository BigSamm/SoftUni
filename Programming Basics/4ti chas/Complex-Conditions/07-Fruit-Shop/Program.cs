using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fr = Console.ReadLine().ToLower();
            var d = Console.ReadLine();
            var kol = double.Parse(Console.ReadLine());
            double price = -1;

            var day1 = (d == "Monday" || d == "Tuesday" || d == "Wednesday" || d == "Thursday" || d == "Friday");
            var day2 = (d == "Saturday" || d == "Sunday"); 
            
            if (day1)
            {
                if (fr == "banana") price = 2.5;
                else if (fr == "apple") price = 1.2;
                else if (fr == "orange") price = .85;
                else if (fr == "grapefruit") price = 1.45;
                else if (fr == "kiwi") price = 2.7;
                else if (fr == "pineapple") price = 5.5;
                else if (fr == "grapes") price = 3.85;
            }
            else if (day2)
            {
                if (fr == "banana") price = 2.7;
                else if (fr == "apple") price = 1.25;
                else if (fr == "orange") price = .9;
                else if (fr == "grapefruit") price = 1.6;
                else if (fr == "kiwi") price = 3;
                else if (fr == "pineapple") price = 5.6;
                else if (fr == "grapes") price = 4.2;
            }

            if (price > 0) Console.WriteLine("{0:f2}", Math.Round(kol * price, 2));
            else Console.WriteLine("error");
            
        }
    }
}
