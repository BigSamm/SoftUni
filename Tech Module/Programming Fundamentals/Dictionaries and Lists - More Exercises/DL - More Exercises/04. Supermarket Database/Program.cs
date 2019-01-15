using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Supermarket_Database
{
    class Program
    {
        static void Main(string[] args)
        {
            var prices = new Dictionary<string, double>();
            var quantity = new Dictionary<string, int>();
            for (;;)
            {
                var product = Console.ReadLine().Split().ToList();
                var prod = product[0];
                if (product[0] == "stocked")
                {
                    var grandTotal = 0.0;
                    var productTotalValue = 0.0;
                    foreach (var item in prices.Zip(quantity, Tuple.Create))
                    {
                        productTotalValue = item.Item1.Value * item.Item2.Value;
                        grandTotal += productTotalValue;
                        Console.WriteLine($"{item.Item1.Key}: ${item.Item1.Value:F2} * {item.Item2.Value} = ${productTotalValue:F2}");
                    }
                    Console.WriteLine("------------------------------");
                    Console.WriteLine($"Grand Total: ${grandTotal:f2}");
                        break;
                }
                var prodPrice = double.Parse(product[1]);
                var prodQuantity = int.Parse(product[2]);

                prices[prod] = prodPrice;
                if (quantity.ContainsKey(prod))
                    quantity[prod] += prodQuantity;
                else
                    quantity[prod] = prodQuantity;
            }
        }
    }
}
