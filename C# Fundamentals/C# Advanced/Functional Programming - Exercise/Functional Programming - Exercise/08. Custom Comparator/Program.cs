using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int[]> takeEvenNums = n => n.Where(x => x % 2 == 0).ToArray();
            Func<int[], int[]> takeOddNums = n => n.Where(x => x % 2 == 1 || x % 2 == -1).ToArray();

            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var evenNums = takeEvenNums(nums);
            Array.Sort(evenNums);
            var oddNums = takeOddNums(nums);
            Array.Sort(oddNums);

            Console.Write(String.Join(" ", evenNums) + " ");
            Console.WriteLine(String.Join(" ", oddNums));
        }
    }
}