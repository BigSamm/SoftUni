using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Array_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long minValue = long.MaxValue;
            long maxValue = long.MinValue;
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                    minValue = arr[i];
                if (arr[i] > maxValue)
                    maxValue = arr[i];
                sum += arr[i];
            }
            double average = sum * 1.0 / arr.Length;
            Console.WriteLine($"Min = {minValue}");
            Console.WriteLine($"Max = {maxValue}");
            Console.WriteLine($"Sum = {sum}");
            Console.WriteLine($"Average = {average}");
        }
    }
}
