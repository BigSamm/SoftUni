using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            var juniors = int.Parse(Console.ReadLine());
            var seniors = int.Parse(Console.ReadLine());
            var type = Console.ReadLine().ToLower();
            var money = 0.0;

            if (type == "trail")
            {
                money += juniors * 5.5;
                money += seniors * 7;
            }

            else if (type == "cross-country" && juniors + seniors >= 50)
            {
                money += juniors * (8 * .75);
                money += seniors * (9.5 * .75);
            }

            else if (type == "cross-country" && juniors + seniors < 50)
            {
                money += juniors * 8;
                money += seniors * 9.5;
            }

            else if (type == "downhill")
            {
                money += juniors * 12.25;
                money += seniors * 13.75;
            }

            else if (type == "road")
            {
                money += juniors * 20;
                money += seniors * 21.5;
            }

            money -= money * .05;

            Console.WriteLine("{0:f2}", Math.Round(money, 2));





        }
    }
}
