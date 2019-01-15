using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Count_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] countArr = new int[1000];
            for (int i = 0; i < nums.Count; i++)
            {
                var x = nums[i];
                countArr[x]++;
            }

            for (int i = 0; i < countArr.Length; i++)
            {
                if(countArr[i] > 0)
                    Console.WriteLine($"{i} -> {countArr[i]}");
            }
        }
    }
}
