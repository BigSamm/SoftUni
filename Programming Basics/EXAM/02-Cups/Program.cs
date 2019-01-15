using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Cups
{
    class Program
    {
        static void Main(string[] args)
        {
            var cupsBr = double.Parse(Console.ReadLine());
            var workersBr = int.Parse(Console.ReadLine());
            var workdays = int.Parse(Console.ReadLine());

            var hours = workersBr * workdays * 8;
            var cups = Math.Floor(hours / 5.0);

            var loses = (cupsBr - cups) * 4.2;
            var extraMoney = (cups - cupsBr) * 4.2;

            if (cups < cupsBr) Console.WriteLine("Losses: {0:f2}", loses);
            else Console.WriteLine("{0:f2} extra money", extraMoney);
        }
    }
}
