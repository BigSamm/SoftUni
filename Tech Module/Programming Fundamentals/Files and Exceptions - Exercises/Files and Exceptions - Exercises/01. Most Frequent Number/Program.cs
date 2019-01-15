using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();

            var numsCount = new Dictionary<string, int>();
            foreach (var num in nums)
            {
                if (numsCount.ContainsKey(num))
                    numsCount[num]++;
                else
                    numsCount[num] = 0;
            }

            string mostFrequentNum = numsCount.OrderBy(n => -n.Value).First().Key;
            Console.WriteLine(mostFrequentNum);
        }
    }
}
