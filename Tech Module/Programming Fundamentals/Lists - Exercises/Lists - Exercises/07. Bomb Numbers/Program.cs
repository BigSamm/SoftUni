using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> bombNums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();

            if (nums.Contains(bombNums[0]))
            {
                long sum = 0;
                long count = 0;
                for (int i = 0; i < nums.Count; i++)
                {
                    if (nums[i] == bombNums[0])
                        count++;
                }
                for (int h = 0; h < count; h++)
                {
                    int bombIndex = nums.IndexOf(bombNums[0]);
                    for (int i = bombIndex + (int)bombNums[1]; i >= bombIndex + 1; i--)
                    {
                        if (i < nums.Count)
                            nums.RemoveAt(i);
                        else
                        {
                            i = nums.Count - 1;
                            nums.RemoveAt(i);
                        }
                    }
                    for (int i = bombIndex - 1; i >= bombIndex - bombNums[1]; i--)
                    {
                        nums.RemoveAt(i);
                        if (i == 0)
                            break;
                    }
                    bombIndex = nums.IndexOf(bombNums[0]);
                    nums.RemoveAt(bombIndex);
                }
                for (int i = 0; i < nums.Count; i++)
                {
                    sum += nums[i];
                }
                Console.WriteLine(sum);
            }



        }
    }
}
