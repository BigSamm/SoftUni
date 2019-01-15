using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
            for (int i = 0; i < nums.Count; i++)
            {
                for (int h = 0; h < nums.Count - 1; h++)
                {
                    if(nums[h] == nums[h+1])
                    {
                        nums[h] *= 2;
                        nums.RemoveAt(h+1);
                    }
                }
            }
            Console.WriteLine(string.Join(" ", nums));


        }
    }
}
