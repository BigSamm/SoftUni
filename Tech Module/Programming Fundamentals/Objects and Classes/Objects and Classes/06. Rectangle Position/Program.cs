using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    class Program
    {
        class Rectangle
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public int Right { get { return Left + Width; } }
            public int Bottom { get { return Top + Height; } }
        }

        static void Main(string[] args)
        {
            Rectangle rectangle1 = GetRectangle();
            Rectangle rectangle2 = GetRectangle();
            bool isInside = IsOneInsideOther(rectangle1, rectangle2);
            if(isInside)
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Not inside");
        }

        static bool IsOneInsideOther(Rectangle rec1, Rectangle rec2)
        {
            if (rec1.Top <= rec2.Top && rec1.Bottom <= rec2.Bottom &&
                rec1.Left >= rec2.Left && rec1.Right <= rec2.Right)
            {
                return true;
            }
            return false;
        }

        static Rectangle GetRectangle()
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToList();
            Rectangle rectangle = new Rectangle();
            rectangle.Left = input[0];
            rectangle.Top = input[1];
            rectangle.Width = input[2];
            rectangle.Height = input[3];
            return rectangle;
        }
    }
}
