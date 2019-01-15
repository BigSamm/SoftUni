using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Queue<double> numbers = new Queue<double>();
            double diff = 0;
            double sum = 0;
            double sum1 = 0;
            if (n > 1)
            {
                for (int i = 0; i < n; i++)
                {
                    var one = double.Parse(Console.ReadLine());
                    var two = double.Parse(Console.ReadLine());
                    sum = one + two;
                    diff = Math.Abs(sum1 - sum);
                    numbers.Enqueue(diff);
                    sum1 = sum;
                }
                numbers.Dequeue();
                if (numbers.Max() == 0)
                {
                    Console.WriteLine($"Yes, value={sum}");
                }
                else Console.WriteLine($"No, maxdiff={numbers.Max()}");
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    var one = double.Parse(Console.ReadLine());
                    var two = double.Parse(Console.ReadLine());
                    sum = one + two;
                    Console.WriteLine($"Yes, value={sum}");
                }
            }
        }
    }
}
