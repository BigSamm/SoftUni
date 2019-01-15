using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Longest_Increasing_Subsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var len = new int[nums.Length];
            for (int i = 0; i < len.Length; i++)
                len[i] = 1;
            var prev = new int[nums.Length];
            for (int i = 0; i < prev.Length; i++)
                prev[i] = -1;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int h = 0; h < i; h++)
                {
                    if (nums[i] > nums[h])
                    {
                        len[i]++;
                        prev[i] = h;
                    }
                }
            }
        }
    }
}
