using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            for (int i = nums.Count - 1; i >= 0; i--)
            {
                if (nums[i] % 2 == 1)
                    nums.RemoveAt(i);
            }
            double average = nums.Average();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > average)
                    nums[i]++;
                else if (nums[i] <= average)
                    nums[i]--;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
