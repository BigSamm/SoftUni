using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(double.Parse).ToList();
            var result = new SortedDictionary<double, int>();
            foreach(var element in nums)
            {
                if (result.ContainsKey(element))
                    result[element]++;
                else
                    result[element] = 1;
            }

            foreach(var num in result)
                Console.WriteLine($"{num.Key} -> {num.Value}");
        }
    }
}
