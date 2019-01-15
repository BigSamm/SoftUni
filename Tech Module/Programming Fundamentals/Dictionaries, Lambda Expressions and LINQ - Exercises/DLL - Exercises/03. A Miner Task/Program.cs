using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, int>();
            for (;;)
            {
                var resource = Console.ReadLine();
                if (resource == "stop")
                {
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Key + " -> " + item.Value);
                    }
                    break;
                }
                var quantity = int.Parse(Console.ReadLine());

                if (result.ContainsKey(resource))
                    result[resource] += quantity;
                else
                    result[resource] = quantity;
            }




        }
    }
}
