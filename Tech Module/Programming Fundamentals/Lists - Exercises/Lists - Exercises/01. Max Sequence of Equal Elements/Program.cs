using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            long maxSequence = 0;
            long sequence = 1;
            long maxNum = 0;

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    sequence++;
                    if (sequence > maxSequence)
                    {
                        maxSequence = sequence;
                        maxNum = (nums[i]);
                    }
                }
                else
                    sequence = 1;
            }
            for (long i = 0; i < maxSequence; i++)
            {
                Console.Write(maxNum + " ");
            }
            Console.WriteLine();
        }
    }
}