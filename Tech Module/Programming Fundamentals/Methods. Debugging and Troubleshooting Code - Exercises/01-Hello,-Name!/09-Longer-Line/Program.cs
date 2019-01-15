using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Longer_Line
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x3 = double.Parse(Console.ReadLine());
            var y3 = double.Parse(Console.ReadLine());
            var x4 = double.Parse(Console.ReadLine());
            var y4 = double.Parse(Console.ReadLine());

            var firstPairLength = GetLengthBetweenPoints(x1, y1, x2, y2);
            var secondPairLength = GetLengthBetweenPoints(x3, y3, x4, y4);

            if (firstPairLength >= secondPairLength)
            {
                bool greaterLength = IsGreaterLength(x1, y1, x2, y2);
                if(greaterLength)
                    Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
                else Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
            else
            {
                bool greaterLength = IsGreaterLength(x3, y3, x4, y4);
                if (greaterLength)
                    Console.WriteLine($"({x3}, {y3})({x4}, {y4})");
                else Console.WriteLine($"({x4}, {y4})({x3}, {y3})");
            }
        }

        static double GetLengthBetweenPoints(double x1, double y1, double x2, double y2)
        {
            var dist = GetDistBetweenPoints(x1, y1, x2, y2);
            return dist;
        }

        static double GetDistBetweenPoints(double x1, double y1, double x2, double y2)
        {
            var dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return dist;
        }

        static bool IsGreaterLength(double x1, double y1, double x2, double y2)
        {
            var dist1 = GetDistBetweenPoints(x1, y1, 0, 0);
            var dist2 = GetDistBetweenPoints(x2, y2, 0, 0);

            if (dist1 <= dist2)
                return true;
            return false;
        }

    }
}
