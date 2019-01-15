using System;
using System.Collections.Generic;

namespace _06.Traffic_Lights
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = Console.ReadLine().Split();

            var trafficLights = new List<TrafficLight>();

            foreach (var color in colors)
            {
                trafficLights.Add(new TrafficLight(color));
            }

            var updatesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < updatesCount; i++)
            {
                foreach (var trafficLight in trafficLights)
                {
                    trafficLight.Update();
                }

                Console.WriteLine(String.Join(" ", trafficLights));
            }
        }
    }
}
