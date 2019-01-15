using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Crypto_Master
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var maxLength = 0;

            for (int startNumIndex = 0; startNumIndex < nums.Count; startNumIndex++)
            {
                for (int step = 1; step < nums.Count; step++)
                {
                    int currentMaxLength = GetCurrentLength(nums, step, maxLength, startNumIndex);

                    if (currentMaxLength > maxLength)
                        maxLength = currentMaxLength;
                }
            }

            Console.WriteLine(maxLength);
        }

        private static int GetCurrentLength(List<int> nums, int step, int maxLength, int startNumIndex)
        {
            var currentMaxLenght = 0;
            var lastAddedNum = int.MinValue;

            for (int index = startNumIndex; index < int.MaxValue; index += step)
            {
                if (index >= nums.Count)
                    index -= nums.Count;

                if (nums[index] > lastAddedNum)
                {
                    lastAddedNum = nums[index];
                    currentMaxLenght++;
                }
                else
                    break;
            }

            return currentMaxLenght;
        }
    }
}