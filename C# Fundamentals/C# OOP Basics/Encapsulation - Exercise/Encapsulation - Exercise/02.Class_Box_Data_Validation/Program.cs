using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var lengthStr = Console.ReadLine();
        var widthStr = Console.ReadLine();
        var heightStr = Console.ReadLine();

        Box box = new Box();
        try
        {
            box = new Box(lengthStr, widthStr, heightStr);

            var surfaceArea = box.CalculateSurfaceArea();
            var lateralSurfaceArea = box.CalculateLateralSurfaceArea();
            var volume = box.CalculateVolume();

            Print(surfaceArea, lateralSurfaceArea, volume);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private static void Print(double surfaceArea, double lateralSurfaceArea, double volume)
    {
        var result = new StringBuilder();

        result.AppendLine($"Surface Area - {surfaceArea:f2}");
        result.AppendLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
        result.AppendLine($"Volume - {volume:f2}");

        Console.WriteLine(result);
    }
}
