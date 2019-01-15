using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Charity_Marathon
{
    class Program
    {
        static void Main(string[] args)
        {
            var days = long.Parse(Console.ReadLine());
            var runners = long.Parse(Console.ReadLine());
            var numberLaps = long.Parse(Console.ReadLine());
            var lengthLap = long.Parse(Console.ReadLine());
            var trackCapacity = long.Parse(Console.ReadLine());
            var moneyPerKm = decimal.Parse(Console.ReadLine());

            long maxRunners = trackCapacity * days;
            if(runners > maxRunners)
            {
                runners = maxRunners;
            }
            long totalMeters = runners * numberLaps * lengthLap;
            decimal totalKm = totalMeters / 1000;
            decimal earned = totalKm * moneyPerKm;
            Console.WriteLine($"Money raised: {earned:f2}");
        }
    }
}
