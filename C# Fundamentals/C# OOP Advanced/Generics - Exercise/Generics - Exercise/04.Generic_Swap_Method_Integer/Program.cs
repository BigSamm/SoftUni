using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Generic_Swap_Method_Integer
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<int>>();

            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);
                boxes.Add(box);
            }

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstIndex = indexes[0];
            var secondIndex = indexes[1];

            SwapItems(firstIndex, secondIndex, boxes);

            PrintBoxes(boxes);
        }

        private static void PrintBoxes(IEnumerable<Box<int>> boxes)
        {
            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }

        private static void SwapItems(int firstIndex, int secondIndex, List<Box<int>> boxes)
        {
            var item = boxes[firstIndex];

            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = item;
        }
    }
}
