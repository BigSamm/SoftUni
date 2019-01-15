using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : IDrawable
{
    public int Width { get; private set; }
    public int Height { get; private set; }

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }

    public void Draw()
    {
        DrawLine(Width, '*', '*');
        for (int i = 1; i <= Height; i++)
        {
            DrawLine(Width, '*', ' ');
        }
        DrawLine(Width, '*', '*');
    }

    private void DrawLine(int width, char end, char mid)
    {
        Console.Write(end);
        for (int i = 1; i <= width; i++)
        {
            Console.Write(mid);
        }
        Console.WriteLine(end);
    }
}