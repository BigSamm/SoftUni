using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Upgraded_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allProducts = Console.ReadLine().Split(' ').ToArray();
            long[] maxQuantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            for (;;)
            {
                string[] product = Console.ReadLine().Split(' ').ToArray();

                if (product[0] == "done")
                    break;

                int index = Array.IndexOf(allProducts, product[0]);
                long quantities = long.Parse(product[1]);

                if (index > maxQuantities.Length - 1)
                {
                    if(quantities > 0)
                        Console.WriteLine($"We do not have enough {product[0]}");
                    else
                        Console.WriteLine($"{product[0]} x 0 costs 0.00");
                }
                else
                {
                    if (maxQuantities[index] < quantities)
                        Console.WriteLine($"We do not have enough {product[0]}");
                    else
                    {
                        Console.WriteLine($"{product[0]} x {product[1]} costs {quantities * price[index]:f2}");
                        maxQuantities[index] -= quantities;
                    }
                }

            }



        }
    }
}
