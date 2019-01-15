using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Generic_Swap_Method_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var boxes = new List<Box<string>>();

            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                var box = new Box<string>(input);
                boxes.Add(box);
            }

            var indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var firstIndex = indexes[0];
            var secondIndex = indexes[1];

            SwapItems(firstIndex, secondIndex, boxes);

            PrintBoxes(boxes);
        }

        private static void PrintBoxes(IEnumerable<Box<string>> boxes)
        {
            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }

        private static void SwapItems(int firstIndex, int secondIndex, List<Box<string>> boxes)
        {
            var item = boxes[firstIndex];

            boxes[firstIndex] = boxes[secondIndex];
            boxes[secondIndex] = item;
        }
    }
}
