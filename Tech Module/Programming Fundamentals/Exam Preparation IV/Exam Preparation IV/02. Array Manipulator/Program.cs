using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (;;)
            {
                var commandList = Console.ReadLine().Split().ToList();

                if (commandList[0] == "end")
                    break;
                else if (commandList[0] == "exchange")
                    DoExchangeCommand(commandList, nums);
                else if (commandList[0] == "max" || commandList[0] == "min")
                    DoMaxOrMinCommand(commandList, nums);
                else if (commandList[0] == "first" || commandList[0] == "last")
                    PrintPartOfArray(commandList, nums);
            }

            Console.WriteLine($"[{String.Join(", ", nums)}]");
        }

        private static void PrintPartOfArray(List<string> commandList, List<int> nums)
        {
            if (commandList[0] == "last")
                nums.Reverse();

            var num = int.Parse(commandList[1]);
            if(num > nums.Count)
            {
                Console.WriteLine("Invalid count");
                if (commandList[0] == "last")
                    nums.Reverse();
                return;
            }

            var result = new List<int>();
            var evenOrOddNums = new List<int>();

            if(commandList[2] == "even")
                evenOrOddNums = nums.Where(n => n % 2 == 0).ToList();
            else if(commandList[2] == "odd")
                evenOrOddNums = nums.Where(n => n % 2 == 1).ToList();
            
            for (int i = 0; i < Math.Min(num, evenOrOddNums.Count); i++)
                result.Add(evenOrOddNums[i]);

            if (commandList[0] == "last")
                evenOrOddNums.Reverse();

            Console.WriteLine($"[{String.Join(", ", result)}]");

            if (commandList[0] == "last")
                nums.Reverse();
        }

        private static void DoMaxOrMinCommand(List<string> commandList, List<int> nums)
        {
            int magicNum = int.MinValue;
            if (commandList[1] == "even")
            {
                var evenNumsList = nums.Where(n => n % 2 == 0).ToList();
                if (evenNumsList.Count > 0)
                {
                    if (commandList[0] == "max")
                        magicNum = evenNumsList.Max();
                    else if (commandList[0] == "min")
                        magicNum = evenNumsList.Min();
                }
            }
            else if (commandList[1] == "odd")
            {
                var oddNumsList = nums.Where(n => n % 2 == 1).ToList();
                if (oddNumsList.Count > 0)
                {
                    if (commandList[0] == "max")
                        magicNum = oddNumsList.Max();
                    else if (commandList[0] == "min")
                        magicNum = oddNumsList.Min();
                }
            }

            if(magicNum == int.MinValue)
                Console.WriteLine("No matches");
            else
                Console.WriteLine(nums.IndexOf(magicNum));
        }

        private static void DoExchangeCommand(List<string> commandList, List<int> nums)
        {
            var index = int.Parse(commandList[1]);
            if (index < 0 || index >= nums.Count)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            var firstPartList = new List<int>();
            for (int i = 0; i <= index; i++)
                firstPartList.Add(nums[i]);
            var secondPartList = new List<int>();
            for (int i = index + 1; i < nums.Count; i++)
                secondPartList.Add(nums[i]);

            var h = 0;
            foreach (var num in secondPartList)
            {
                nums[h] = num;
                h++;
            }
            foreach (var num in firstPartList)
            {
                nums[h] = num;
                h++;
            }
        }
    }
}
