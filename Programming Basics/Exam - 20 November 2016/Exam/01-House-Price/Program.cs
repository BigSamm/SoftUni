using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_House_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstRoom = double.Parse(Console.ReadLine());
            var kitchen = double.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());

            var bath = 0.5 * firstRoom;
            var secondRoom = firstRoom + firstRoom * .1;
            var thirdRoom = secondRoom + secondRoom * .1;

            var allArea = kitchen + bath + firstRoom + secondRoom + thirdRoom;
            allArea += .05 * allArea;
            var result = allArea * price;

            Console.WriteLine("{0:f2}", Math.Round(result, 2));
        }
    }
}
