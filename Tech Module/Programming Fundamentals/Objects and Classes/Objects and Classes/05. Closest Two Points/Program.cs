using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Closest_Two_Points
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
            Point[] points = ReadPoints();
            Point[] closestPoints = GetClosestPoints(points);
            PrintMinDistance(closestPoints);
            PrintPoint(closestPoints[0]);
            PrintPoint(closestPoints[1]);
        }

        static void PrintPoint(Point p)
        {
            Console.WriteLine($"({p.X}, {p.Y})");
        }

        static void PrintMinDistance(Point[] closestPoints)
        {
            var distance = CalcDistance(closestPoints[0], closestPoints[1]);
            Console.WriteLine($"{distance:f3}");
        }

        static Point[] GetClosestPoints(Point[] points)
        {
            double minDist = double.MaxValue;
            Point[] closestPoints = null;

            for (int p1 = 0; p1 < points.Length; p1++)
            {
                for (int p2 = p1 + 1; p2 < points.Length; p2++)
                {
                    double distance = CalcDistance(points[p1], points[p2]);
                    if (distance < minDist)
                    {
                        minDist = distance;
                        closestPoints = new Point[] {points[p1], points[p2]};
                    }
                }
            }
            return closestPoints;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var distance = Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            return distance;
        }

        static Point[] ReadPoints()
        {
            var n = int.Parse(Console.ReadLine());
            Point[] points = new Point[n];
            for (int i = 0; i < n; i++)
            {
                points[i] = GetPoint();
            }
            return points;
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
