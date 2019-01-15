using System;

class Program
{
    static void Main(string[] args)
    {
        var smartphone = new Smartphone();

        var numberList = Console.ReadLine().Split();
        foreach (var number in numberList)
        {
            smartphone.TryAddNumber(number);
        }

        var browserList = Console.ReadLine().Split();
        foreach (var browser in browserList)
        {
            smartphone.TryAddBrowser(browser);
        }

        Console.WriteLine(smartphone);
    }
}
