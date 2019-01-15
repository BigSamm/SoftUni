using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine();
            double area = 0.0;
            if (figureType == "triangle")
            {
                area = GetTriangleArea();
            }
            else if (figureType == "square")
            {
                area = GetSquareArea();
            }
            else if (figureType == "rectangle")
            {
                area = GetRectangleArea();
            }
            else if (figureType == "circle")
            {
                area = GetCircleArea();
            }
            Console.WriteLine($"{area:f2}");
        }

        static double GetCircleArea()
        {
            var radius = double.Parse(Console.ReadLine());
            return Math.PI * Math.Pow(radius, 2);
        }

        static double GetRectangleArea()
        {
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            return width * height;
        }

        static double GetSquareArea()
        {
            var side = double.Parse(Console.ReadLine());
            return Math.Pow(side, 2);
        }

        static double GetTriangleArea()
        {
            var side = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());
            return side * height / 2;
        }
    }
}
