using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var nums = new List<int>();
            for (int i = 1; i <= num; i++)
            {
                nums.Add(i);
            }

            Func<List<int>, List<int>> takeNums = numbers =>
            {
                dividers.ForEach(divider => numbers = numbers.Where(n => n % divider == 0).ToList());
                return numbers;
            };

            var numsForPrint = takeNums(nums);
            Console.WriteLine(String.Join(" ", numsForPrint));
        }
    }
}