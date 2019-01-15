using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
    class Program
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }

        class SalesByTown
        {
            public string Town { get; set; }
            public decimal Sales { get; set; }
        }

        static void Main(string[] args)
        {
            var sales = GetSales();
            var salesByTown = CalcSalesByTown(sales);
            foreach (var s in salesByTown)
            {
                Console.WriteLine($"{s.Key} -> {s.Value:f2}");
            }
        }

        static SortedDictionary<string, decimal> CalcSalesByTown(Sale[] sales)
        {
            var salesByTowns = new SortedDictionary<string, decimal>();
            foreach (var s in sales)
            {
                if (salesByTowns.ContainsKey(s.Town))
                    salesByTowns[s.Town] += s.Quantity * s.Price;
                else
                    salesByTowns[s.Town] = s.Quantity * s.Price;
            }
            return salesByTowns;

        }

        static Sale[] GetSales()
        {
            var n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var sale = new Sale()
                {
                    Town = input[0],
                    Product = input[1],
                    Price = decimal.Parse(input[2]),
                    Quantity = decimal.Parse(input[3])
                };
                sales[i] = sale;
            }
            return sales;
        }



    }
}