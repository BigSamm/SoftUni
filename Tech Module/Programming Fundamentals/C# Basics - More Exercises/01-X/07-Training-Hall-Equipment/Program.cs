using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var itemsNum = int.Parse(Console.ReadLine());
            var sum = 0.0;

            for (int i = 0; i < itemsNum; i++)
            {
                var name = Console.ReadLine();
                var price = double.Parse(Console.ReadLine());
                var count = int.Parse(Console.ReadLine());

                if(count == 1)
                    Console.WriteLine($"Adding {count} {name} to cart.");
                else
                    Console.WriteLine($"Adding {count} {name}s to cart.");

                budget -= price * count;
                sum += price * count;

            }
            
            if(budget >= 0)
            {
                Console.WriteLine($"Subtotal: ${sum:f2}");
                Console.WriteLine($"Money left: ${budget:f2}");
            }
            else
            {
                Console.WriteLine($"Subtotal: ${sum:f2}");
                Console.WriteLine($"Not enough. We need ${Math.Abs(budget):f2} more.");
            }




        }
    }
}
