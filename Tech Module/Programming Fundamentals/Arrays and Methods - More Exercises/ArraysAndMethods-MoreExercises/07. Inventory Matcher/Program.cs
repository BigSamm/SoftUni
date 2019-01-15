using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Inventory_Matcher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] products = Console.ReadLine().Split(' ').ToArray();
            long[] quantities = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            decimal[] price = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
            for (;;)
            {
                string prod = Console.ReadLine();
                if (prod == "done")
                    break;
                int index = Array.IndexOf(products, prod);
                if (prod == products[index])
                    Console.WriteLine($"{prod} costs: {price[index]}; Available quantity: {quantities[index]}");
            }
        }
    }
}
