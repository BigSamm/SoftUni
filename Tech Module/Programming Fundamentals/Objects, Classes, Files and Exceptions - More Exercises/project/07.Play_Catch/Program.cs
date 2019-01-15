using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.Play_Catch
{
    class Program
    {
        public static object IEnumarable { get; private set; }

        static void Main()
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int exceptionsCount = 0;

            while (exceptionsCount < 3)
            {
                try
                {
                    string[] args = Console.ReadLine().Split();
                    string command = args[0];
                    int index = int.Parse(args[1]);

                    switch (command)
                    {
                        case "Replace":
                            int element = int.Parse(args[2]);
                            nums[index] = element;
                            break;
                        case "Print":
                            int endIndex = int.Parse(args[2]);
                            int[] result = TakeNeededNums(index, endIndex, nums);
                            PrintNums(result);
                            break;
                        case "Show":
                            Console.WriteLine(nums[index]);
                            break;
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionsCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionsCount++;
                }
            }

            PrintNums(nums);
        }

        private static int[] TakeNeededNums(int index, int endIndex, int[] nums)
        {
            int[] result = new int[endIndex - index + 1];
            int resultIndex = 0;

            for (int i = index; i <= endIndex; i++)
            {
                result[resultIndex] = nums[i];
                resultIndex++;
            }

            return result;
        }

        private static void PrintNums(IEnumerable<int> nums)
        {
            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
