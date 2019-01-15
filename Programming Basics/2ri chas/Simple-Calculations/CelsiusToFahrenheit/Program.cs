using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celsius= ");
            var C = double.Parse(Console.ReadLine());
            var F = Math.Round(C * 1.8000 + 32, 2);
            Console.Write("Fahrenheit= ");
            Console.WriteLine(F);
        }
    }
}
