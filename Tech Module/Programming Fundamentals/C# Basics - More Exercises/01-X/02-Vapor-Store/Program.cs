using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = double.Parse(Console.ReadLine());
            var allmoney = n;

            for (;;)
            {
                var game = Console.ReadLine();

                if (n == 0.0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                else if (game == "OutFall 4")
                {
                    if (n < 39.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        n -= 39.99;
                        Console.WriteLine("Bought OutFall 4");
                    }
                }
                else if (game == "CS: OG")
                {
                    if (n < 15.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        n -= 15.99;
                        Console.WriteLine("Bought CS: OG");
                    }
                }
                else if (game == "Zplinter Zell")
                {
                    if (n < 19.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        n -= 19.99;
                        Console.WriteLine("Bought Zplinter Zell");
                    }
                }
                else if (game == "Honored 2")
                {
                    if (n < 59.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        n -= 59.99;
                        Console.WriteLine("Bought Honored 2");
                    }
                }
                else if (game == "RoverWatch")
                {
                    if (n < 29.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        n -= 29.99;
                        Console.WriteLine("Bought RoverWatch");
                    }
                }
                else if (game == "RoverWatch Origins Edition")
                {
                    if (n < 39.99) Console.WriteLine("Too Expensive");
                    else
                    {
                        n -= 39.99;
                        Console.WriteLine("Bought RoverWatch Origins Edition");
                    }
                }
                else if (game == "Game Time")
                {
                    if (n == 0.0) Console.WriteLine("Out of money!");
                    else Console.WriteLine($"Total spent: ${allmoney - n:f2}. Remaining: ${n:f2}");
                    return;
                }
                else Console.WriteLine("Not Found");



            }





        }
    }
}
