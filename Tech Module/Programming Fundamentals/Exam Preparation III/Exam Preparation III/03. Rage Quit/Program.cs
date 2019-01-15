using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();
            var strings = input
                .Split(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' },
                StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var nums = GetAllNums(input);

            var result = "";
            for (int i = 0; i < strings.Count; i++)
            {
                for (int h = 0; h < nums[i]; h++)
                {
                    result += strings[i];
                }
            }
            var uniqueSymbols = GetUniqueSymbols(result);
            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(result);
        }

        static List<int> GetAllNums(string input)
        {
            var inputArr = input.ToCharArray();
            var numString = "";
            for (int i = 0; i < inputArr.Length - 1; i++)
            {
                if ((inputArr[i] >= 48 && inputArr[i] <= 57) &&
                    (inputArr[i + 1] < 48 || inputArr[i + 1] > 57))
                {
                    numString += inputArr[i] + " ";
                }
                else if ((inputArr[i] >= 48 && inputArr[i] <= 57) &&
                    (inputArr[i + 1] >= 48 && inputArr[i + 1] <= 57))
                {
                    numString += inputArr[i];
                }
            }
            if (inputArr[inputArr.Length - 1] >= 48 && inputArr[inputArr.Length - 1] <= 57)
            {
                numString += inputArr[inputArr.Length - 1];
            }
            var nums = numString.Split().Select(int.Parse).ToList();
            return nums;
        }

        static List<char> GetUniqueSymbols(string result)
        {
            var allSymbols = new List<char>();
            var allString = result.ToCharArray();
            for (int i = 0; i < allString.Length; i++)
            {
                allSymbols.Add(allString[i]);
            }
            var uniqueSymbols = allSymbols.Distinct().ToList();
            return uniqueSymbols;
        }
    }
}
