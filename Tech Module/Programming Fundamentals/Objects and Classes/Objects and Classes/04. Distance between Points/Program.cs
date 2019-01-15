using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Distance_between_Points
{
    class Program
    {
        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        static void Main(string[] args)
        {
            Point p1 = GetPoint();
            Point p2 = GetPoint();

            double distance = CalcDistance(p1, p2);

            Console.WriteLine($"{distance:f3}");
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var distance = Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            return distance;
        }

        static Point GetPoint()
        {
            var n = Console.ReadLine().Split().Select(int.Parse).ToList();
            Point point = new Point();
            point.X = n[0];
            point.Y = n[1];
            return point;
        }
    }
}
