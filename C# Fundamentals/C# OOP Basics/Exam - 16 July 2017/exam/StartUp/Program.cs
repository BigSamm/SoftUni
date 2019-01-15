using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        var draftManager = new DraftManager();

        string inpuLine;
        while ((inpuLine = Console.ReadLine()) != "Shutdown")
        {
            var arguments = inpuLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToList();
            var command = arguments[0];
            arguments = arguments.Skip(1).ToList();

            switch (command)
            {
                case "RegisterHarvester":
                    Console.WriteLine(draftManager.RegisterHarvester(arguments));
                    break;
                case "RegisterProvider":
                    Console.WriteLine(draftManager.RegisterProvider(arguments));
                    break;
                case "Day":
                    Console.WriteLine(draftManager.Day());
                    break;
                case "Mode":
                    Console.WriteLine(draftManager.Mode(arguments));
                    break;
                case "Check":
                    Console.WriteLine(draftManager.Check(arguments));
                    break;
            }
        }

        Console.WriteLine(draftManager.ShutDown());
    }
}