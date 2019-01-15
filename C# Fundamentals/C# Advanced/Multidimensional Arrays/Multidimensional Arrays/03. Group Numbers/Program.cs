using System;
using System.Linq;

namespace _03.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = ReadFromConsole();

            int[] sizes = new int[3];
            foreach (var num in nums)
            {
                int reminder = Math.Abs(num % 3);
                sizes[reminder]++;
            }

            int[][] array =
            {
                new int[sizes[0]],
                new int[sizes[1]],
                new int[sizes[2]]
            };

            int[] offsets = new int[3];
            foreach (var num in nums)
            {
                var remainder = Math.Abs(num % 3);
                var index = offsets[remainder];
                array[remainder][index] = num;
                offsets[remainder]++;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(String.Join(" ", array[i]));
            }
        }

        private static int[] ReadFromConsole()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return input;
        }
    }
}