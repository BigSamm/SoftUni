using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLet = char.Parse(Console.ReadLine());
            var secondtLet = char.Parse(Console.ReadLine());
            var letter = char.Parse(Console.ReadLine());

            for (char i = firstLet; i <= secondtLet; i++)
            {
                for (char h = firstLet; h <= secondtLet; h++)
                {
                    for (char g = firstLet; g <= secondtLet; g++)
                    {
                        if (i != letter && h != letter && g != letter)
                            Console.Write($"{i}{h}{g} ");
                    }
                }
            }

            

        }
    }
}
