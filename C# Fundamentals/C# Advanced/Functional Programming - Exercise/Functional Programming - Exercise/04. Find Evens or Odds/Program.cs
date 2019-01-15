using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var command = Console.ReadLine();

            Predicate<int> evenOrOdd = n =>
            {
                if (command == "even")
                    return n % 2 == 0;
                else
                    return n % 2 == 1;
            };

            for (int i = nums[0]; i <= nums[1]; i++)
            {
                if (evenOrOdd(Math.Abs(i)))
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}