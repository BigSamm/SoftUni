using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Jump_Around
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] nums = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long sum = 0;
            long index = 0;
            for (;;)
            {
                sum += nums[index];
                if (index + nums[index] > nums.Length - 1)
                {
                    if (index - nums[index] < 0)
                        break;
                    else
                        index -= nums[index];
                }
                else
                    index += nums[index];
            }
            Console.WriteLine(sum);


        }
    }
}
