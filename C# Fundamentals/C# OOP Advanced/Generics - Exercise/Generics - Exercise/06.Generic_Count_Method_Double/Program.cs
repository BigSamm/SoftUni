using System;
using System.Collections.Generic;

namespace _05.Generic_Count_Method_String
{
    class Program
    {
        static void Main(string[] args)
        {
            var elements = new List<double>();

            var lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var inputLine = double.Parse(Console.ReadLine());
                elements.Add(inputLine);
            }

            var elementForCompare = double.Parse(Console.ReadLine());
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
