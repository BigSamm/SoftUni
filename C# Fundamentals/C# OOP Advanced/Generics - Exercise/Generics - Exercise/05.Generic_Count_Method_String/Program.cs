using System;
using System.Collections.Generic;

namespace _05.Generic_Count_Method_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new List<string>();

            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var inputLine = Console.ReadLine();
                elements.Add(inputLine);
            }

            var elementForCompare = Console.ReadLine();
            int result = GetGreaterElementsCount(elements, elementForCompare);
            Console.WriteLine(result);
        }

        private static int GetGreaterElementsCount<T>(List<T> elements, T element)
            where T : IComparable<T>
        {
            var greaterCount = 0;

            foreach (var item in elements)
            {
                var compareResult = item.CompareTo(element);
                if (compareResult > 0)
                    greaterCount++;
            }

            return greaterCount;
        }
    }
}
