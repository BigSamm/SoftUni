using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var result = nums.OrderByDescending(x => x).Take(3).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
