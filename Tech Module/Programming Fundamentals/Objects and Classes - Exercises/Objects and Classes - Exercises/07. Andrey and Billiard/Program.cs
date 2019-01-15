using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Andrey_and_Billiard
{
    class Program
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopList { get; set; }
            public decimal Bill { get; set; }
        }

        static void Main(string[] args)
        {
            var allProducts = GetAllProducts();
            Customer[] customers = GetAllCustomers(allProducts);
        }

        static Customer[] GetAllCustomers(Dictionary<string, decimal> allProducts)
        {
            var customers = new List<Customer>();
            for (;;)
            {
                var input = Console.ReadLine().Split(new char[] { '-', ',' },
                    StringSplitOptions.RemoveEmptyEntries).ToList();
                if (allProducts.ContainsKey(input[1]))
                {
                    Customer currentCustomer = new Customer()
                    {
                        Name = input[0],
                        //ShopList[input[1]] = int.Parse(input[2])
                    };
                }
            }
        }

        static Dictionary<string, decimal> GetAllProducts()
        {
            var n = int.Parse(Console.ReadLine());
            var allProducts = new Dictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split('-').ToList();
                var product = input[0];
                var price = decimal.Parse(input[1]);
                allProducts[product] = price;
            }
            return allProducts;
        }
    }
}
