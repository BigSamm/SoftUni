using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Sum_Reversed_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').ToList();
            List<int> result = new List<int>();
            for (int i = 0; i < nums.Count; i++)
            {
                char[] numToArr = nums[i].ToCharArray();
                Array.Reverse(numToArr);
                result.Add(int.Parse(string.Join("", numToArr)));
            }
            var sum = 0;
            for (int i = 0; i < result.Count; i++)
            {
                sum += result[i];
            }
            Console.WriteLine(sum);

        }
    }
}
