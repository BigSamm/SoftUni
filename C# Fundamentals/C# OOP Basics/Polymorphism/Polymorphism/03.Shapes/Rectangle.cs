using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle : Shape
{
    private int height;
    private int width;

    public Rectangle(int height, int width)
    {
        this.Height = height;
        this.Width = width;
    }

    public int Width
    {
        get { return width; }
        private set { width = value; }
    }

    public int Height
    {
        get { return height; }
        private set { height = value; }
    }
}