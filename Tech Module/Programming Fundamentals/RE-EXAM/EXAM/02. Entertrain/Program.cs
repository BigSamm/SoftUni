using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            var power = int.Parse(Console.ReadLine());

            int allWeight = 0;
            var allWagons = new List<int>();
            
            for (;;)
            {
                if (allWeight > power)
                {
                    double average = allWeight * 1.0 / allWagons.Count;
                    double minDiff = double.MaxValue;
                    int elementToRemove = 0;
                    for (int i = 0; i < allWagons.Count; i++)
                    {
                        if (Math.Abs(average - allWagons[i]) < minDiff)
                        {
                            minDiff = Math.Abs(average - allWagons[i]);
                            elementToRemove = allWagons[i];
                        }
                    }
                    allWagons.Remove(elementToRemove);
                    allWeight -= elementToRemove;
                }

                var input = Console.ReadLine();
                if (input == "All ofboard!") break;

                var weight = int.Parse(input);

                allWeight += weight;
                allWagons.Add(weight);
            }

            allWagons.Reverse();
            allWagons.Add(power);
            Console.Write(String.Join(" ", allWagons));
        }
    }
}