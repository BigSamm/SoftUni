using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());

            var maxLenght = IsTheMaxLength(x1, y1, x2, y2);

            if(maxLenght)
                Console.WriteLine($"({x1}, {y1})");
            else
                Console.WriteLine($"({x2}, {y2})");
        }

        static bool IsTheMaxLength(double x1, double y1, double x2, double y2)
        {
            var dist1 = GetDistBetweenPoints(x1, y1, 0, 0);
            var dist2 = GetDistBetweenPoints(x2, y2, 0, 0);

            if(dist1 <= dist2)
                return true;
            return false;
        }

        static double GetDistBetweenPoints(double x1, double y1, double x2, double y2)
        {
            var dist = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return dist;
        }
    }
}
