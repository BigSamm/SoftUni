using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var x4 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());
            var y4 = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var result = "";

            int[] ArrayXY = new int[4] { x1, x2, x3, x4 };
            Array.Sort(ArrayXY);
            var XX1 = ArrayXY[0];
            var XX2 = ArrayXY[1];
            var XX3 = ArrayXY[2];
            var XX4 = ArrayXY[3];

            ArrayXY = new int[4] { y1, y2, y3, y4 };
            Array.Sort(ArrayXY);
            var YY1 = ArrayXY[0];
            var YY2 = ArrayXY[1];
            var YY3 = ArrayXY[2];
            var YY4 = ArrayXY[3];

            if (x > XX1 && x < XX4 && y > YY2 && y < YY3)
                result = "Inside";
            else if (x > XX2 && x < XX3 && y > YY1 && y < YY4)
                result = "Inside";
            else if (x == XX1 && y > YY2 && y < YY3 ||
                     y == YY4 && x > XX2 && x < XX3 ||
                     x == XX4 && y > YY2 && y < YY3 ||
                     y == YY1 && x > XX2 && x < XX3 ||
                     y == YY3 && x > XX1 && x < XX2 ||
                     x == XX2 && y > YY3 && y < YY4 ||
                     x == XX3 && y > YY3 && y < YY4 ||
                     y == YY3 && x > XX3 && x < XX4 ||
                     y == YY2 && x > XX3 && x < XX4 ||
                     x == XX3 && y > YY1 && y < YY2 ||
                     x == XX2 && y > YY1 && y < YY2 ||
                     y == YY2 && x > XX1 && x < XX2)
                result = "Border";
            else if (x == XX1 && y == YY3 ||
                     x == XX2 && y == YY3 ||
                     x == XX2 && y == YY4 ||
                     x == XX3 && y == YY4 ||
                     x == XX3 && y == YY3 ||
                     x == XX4 && y == YY3 ||
                     x == XX4 && y == YY2 ||
                     x == XX3 && y == YY2 ||
                     x == XX3 && y == YY1 ||
                     x == XX2 && y == YY1 ||
                     x == XX2 && y == YY2 ||
                     x == XX1 && y == YY2)
                result = "Corner";
            else result = "Outside";

            Console.WriteLine(result);


            int i;

            Console.Write(new string(' ',  XX1 - 1));
            Console.Write(new string(' ', XX2 - XX1));
            Console.WriteLine(new string('*', XX3 - XX2 + 1));
            for (i = 0; i < YY4 - YY3 - 1; i++)
            {
                Console.Write(new string(' ', XX1 - 1));
                Console.Write(new string(' ', XX2 - XX1));
                Console.Write("*");
                Console.Write(new string(' ', XX3 - XX2 - 1));
                Console.WriteLine("*");
            }

            Console.Write(new string(' ', XX1 - 1));
            Console.Write(new string('*', XX2 - XX1 + 1));
            Console.Write(new string(' ', XX3 - XX2 - 1));
            Console.WriteLine(new string('*', XX4 - XX3 + 1));
            for (i = 0; i < YY3 - YY2 - 1; i++)
            {
                Console.Write(new string(' ', XX1 - 1));
                Console.Write("*");
                Console.Write(new string(' ', XX4 - XX1 - 1));
                Console.WriteLine("*");
            }
            Console.Write(new string(' ', XX1 - 1));
            Console.Write(new string('*', XX2 - XX1 + 1));
            Console.Write(new string(' ', XX3 - XX2 - 1));
            Console.WriteLine(new string('*', XX4 - XX3 + 1));

            for (i = 0; i < YY4 - YY3 - 1; i++)
            {
                Console.Write(new string(' ', XX1 - 1));
                Console.Write(new string(' ', XX2 - XX1));
                Console.Write("*");
                Console.Write(new string(' ', XX3 - XX2 - 1));
                Console.WriteLine("*");
            }
            Console.Write(new string(' ', XX1 - 1));
            Console.Write(new string(' ', XX2 - XX1));
            Console.WriteLine(new string('*', XX3 - XX2 + 1));
           
        }
    }
}
