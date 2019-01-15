using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    public string Id { get; set; }
    public double Width { get; set; }
    public double Height { get; set; }
    public double X { get; set; }
    public double Y { get; set; }

    public Rectangle(string id, double width, double height, double x, double y)
    {
        Id = id;
        Width = width;
        Height = height;
        X = x;
        Y = y;
    }

    public static bool IsIntersect(Rectangle rect1, Rectangle rect2)
    {
        if (rect1 == null || rect2 == null)
            return false;

        double x1 = Math.Max(rect1.X, rect2.X);
        double x2 = Math.Min(rect1.X + rect1.Width, rect2.X + rect2.Width);
        double y1 = Math.Max(rect1.Y, rect2.Y);
        double y2 = Math.Min(rect1.Y + rect1.Height, rect2.Y + rect2.Height);

        return (x2 >= x1 && y2 >= y1);
    }
}
