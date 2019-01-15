using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var numsCount = new Dictionary<string, int>();

            string[] nums = Console.ReadLine().Split();
            foreach (var num in nums)
            {
                if (numsCount.ContainsKey(num))
                    numsCount[num]++;
                else
                    numsCount[num] = 1;
            }

            KeyValuePair<string, int> mostFrequentNum = numsCount.OrderBy(n => -n.Value).First();

            for (int i = 0; i < mostFrequentNum.Value - 1; i++)
            {
                Console.Write(mostFrequentNum.Key + " ");
            }
            Console.WriteLine(mostFrequentNum.Key);
        }
    }
}
