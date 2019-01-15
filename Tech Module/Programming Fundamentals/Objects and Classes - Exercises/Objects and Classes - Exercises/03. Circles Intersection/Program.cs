using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Circles_Intersection
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
            var firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            Point firstCenter = GetCenter(firstInput);
            Point secondCenter = GetCenter(secondInput);

            var firstRadius = firstInput[2];
            var secondRadius = secondInput[2];

            double distance = CalcDistance(firstCenter, secondCenter);

            if(distance <= firstRadius + secondRadius)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
        }

        static Point GetCenter(List<int> input)
        {
            Point center = new Point
            {
                X = input[0],
                Y = input[1]
            };
            return center;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var distance = Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y));
            return distance;
        }
    }
}
