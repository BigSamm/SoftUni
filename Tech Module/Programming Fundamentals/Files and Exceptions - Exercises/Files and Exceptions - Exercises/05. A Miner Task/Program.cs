using System;
using System.Collections.Generic;

namespace _05._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();

            string input;
            while((input = Console.ReadLine()) != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(input))
                    resources[input] += quantity;
                else
                    resources[input] = quantity;
            }

            foreach (var resource in resources)
            {
                Console.WriteLine(resource.Key + " -> " + resource.Value);
            }
        }
    }
}
