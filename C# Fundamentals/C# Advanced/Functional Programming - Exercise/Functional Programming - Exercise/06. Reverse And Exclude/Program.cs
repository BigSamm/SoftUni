using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            var divisor = int.Parse(Console.ReadLine());

            Func<List<int>, List<int>> removeElements = n => n.Where(x => x % divisor != 0).ToList();
            Action<List<int>> reverse = n => n.Reverse();

            nums = removeElements(nums);
            reverse(nums);

            Console.WriteLine(String.Join(" ", nums));
        }
    }
}