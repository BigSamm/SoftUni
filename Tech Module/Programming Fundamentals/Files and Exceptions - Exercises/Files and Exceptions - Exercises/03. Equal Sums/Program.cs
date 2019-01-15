using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int index = 0; index < nums.Length; index++)
            {
                int leftSum = 0;
                for (int i = index - 1; i >= 0; i--)
                {
                    leftSum += nums[i];
                }

                int rightSum = 0;
                for (int i = index + 1; i < nums.Length; i++)
                {
                    rightSum += nums[i];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(index);
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("no");
        }
    }
}
