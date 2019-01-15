using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            var drivers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var trackZones = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            var checkpointIndexes = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            checkpointIndexes = checkpointIndexes.Distinct().ToList();

            for (int h = 0; h < trackZones.Count; h++)
            {
                for (int g = 0; g < checkpointIndexes.Count; g++)
                {
                    if (h == checkpointIndexes[g])
                    {
                        trackZones[h] = -trackZones[h];
                    }
                }
            }

            for (int i = 0; i < drivers.Count; i++)
            {
                var name = drivers[i];
                double fuel = GetDriverFuel(name);

                var isFinish = true;
                for (int h = 0; h < trackZones.Count; h++)
                {
                    fuel -= trackZones[h];
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{name} - reached {h}");
                        isFinish = false;
                        break;
                    }
                }
                if (isFinish)
                {
                    Console.WriteLine($"{name} - fuel left {fuel:f2}");
                }
            }
        }

        static double GetDriverFuel(string name)
        {
            double fuel = name.ToCharArray().FirstOrDefault();
            return fuel;
        }
    }
}
