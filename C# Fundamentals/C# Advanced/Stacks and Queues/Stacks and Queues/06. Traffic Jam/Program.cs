using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsForPass = int.Parse(Console.ReadLine());

            var allCars = new Queue<string>();
            var allCarsPassed = 0;
            for(;;)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "end")
                {
                    Console.WriteLine($"{allCarsPassed} cars passed the crossroads.");
                    Environment.Exit(0);
                }
                else if (inputLine == "green")
                {
                    for (int i = 0; i < carsForPass; i++)
                    {
                        while(allCars.Count > 0)
                        {
                            var passedCar = allCars.Dequeue();
                            Console.WriteLine($"{passedCar} passed!");
                            allCarsPassed++;
                            break;
                        }
                    }
                }
                else
                {
                    allCars.Enqueue(inputLine);
                }
            }
        }
    }
}