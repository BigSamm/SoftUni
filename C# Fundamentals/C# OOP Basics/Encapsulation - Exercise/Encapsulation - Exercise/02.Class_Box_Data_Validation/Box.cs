using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double length;
    private double width;
    private double height;

    public double Height
    {
        get { return height; }
        private set
        {
            ValidateValue(value, "Height");
            height = value;
        }
    }

    public double Width
    {
        get { return width; }
        private set
        {
            ValidateValue(value, "Width");
            width = value;
        }
    }
    
    public double Length
    {
        get { return length; }
        private set
        {
            ValidateValue(value, "Length");
            length = value;
        }
    }
    
    public Box() { }

    public Box(string lengthStr, string widthStr, string heightStr)
    {
        Length = double.Parse(lengthStr);
        Width = double.Parse(widthStr);
        Height = double.Parse(heightStr);
    }

    private void ValidateValue(double value, string property)
    {
        if (value <= 0)
            throw new ArgumentException($"{property} cannot be zero or negative. ");
    }

    public double CalculateSurfaceArea()
    {
        return 2 * (Length * Width + Length * Height + Width * Height);
    }

    public double CalculateLateralSurfaceArea()
    {
        return 2 * (Length * Height + Width * Height);
    }

    public double CalculateVolume()
    {
        return Length * Width * Height;
    }
}
