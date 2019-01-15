using System;

class Program
{
    static void Main(string[] args)
    {
        var dates = new DateModifier(Console.ReadLine(), Console.ReadLine());

        double daysDifference = dates.CalculateDaysDifference();
        Console.WriteLine(daysDifference);
    }
}
