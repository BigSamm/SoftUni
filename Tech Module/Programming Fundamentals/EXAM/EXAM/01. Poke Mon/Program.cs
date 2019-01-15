using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            var power = int.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());

            int targetsCount = 0;
            int powerStartValue = power;

            while (power >= distance)
            {
                power -= distance;
                targetsCount++;

                if (power != 0 && exhaustionFactor != 0)
                {
                    if (powerStartValue / power == 2 && powerStartValue % power == 0)
                        power /= exhaustionFactor;
                }
            }

            Console.WriteLine(power);
            Console.WriteLine(targetsCount);
        }
    }
}