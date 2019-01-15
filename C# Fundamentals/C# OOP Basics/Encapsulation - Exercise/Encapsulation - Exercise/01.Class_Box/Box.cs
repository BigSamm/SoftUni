using System;
using System.Collections.Generic;
using System.Text;

public class Box
{
    private double Length { get; set; }
    private double Width { get; set; }
    private double Height { get; set; }

    public Box(string lengthStr, string widthStr, string heightStr)
    {
        Length = double.Parse(lengthStr);
        Width = double.Parse(widthStr);
        Height = double.Parse(heightStr);
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
