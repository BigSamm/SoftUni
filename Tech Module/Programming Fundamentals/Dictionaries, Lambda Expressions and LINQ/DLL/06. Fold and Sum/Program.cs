using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split().Select(int.Parse).ToList();
            var k = nums.Count() / 4;

            var leftPart = nums.Take(2 * k).ToList();
            var rightPart = nums.Skip(2 * k).Take(2 * k).ToList();

            var firstPart = leftPart.Take(k).Reverse().ToList();
            rightPart.Reverse();
            var fourthPart = rightPart.Take(k).ToList();
            var firstRow = new List<int>();
            for (int i = 0; i < k; i++)
                firstRow.Add(firstPart[i]);
            for (int i = 0; i < k; i++)
                firstRow.Add(fourthPart[i]);

            var secondRow = nums.Skip(k).Take(2 * k).ToList();

            var result = new List<int>();
            for (int i = 0; i < 2*k; i++)
                result.Add(firstRow[i] + secondRow[i]);
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
