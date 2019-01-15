using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var queue = new Queue<int[]>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                queue.Enqueue(input);
            }

            for (int currentStart = 0; currentStart < n; currentStart++)
            {
                long fuel = 0;
                var isSolution = true;

                for (int pumpsPassed = 0; pumpsPassed < n; pumpsPassed++)
                {
                    var currentPump = queue.Dequeue();
                    fuel += currentPump[0];
                    var km = currentPump[1];
                    
                    queue.Enqueue(currentPump);

                    fuel -= km;

                    if(fuel < 0)
                    {
                        currentStart += pumpsPassed;
                        isSolution = false;
                        break;
                    }
                }

                if (isSolution)
                {
                    Console.WriteLine(currentStart);
                    Environment.Exit(0);
                }
            }
        }
    }
}