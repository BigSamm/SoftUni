using System;
using System.Linq;
using System.Text;

namespace _11.Poisonous_Plants
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var plants = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var counter = 0;
            for (;;)
            {
                var isSolution = true;

                for (int i = plants.Count - 1; i > 0; i--)
                {
                    if (plants[i] > plants[i - 1])
                    {
                        plants[i] = -1;
                        isSolution = false;
                    }
                }

                plants.RemoveAll(p => p == -1);

                if (isSolution)
                {
                    Console.WriteLine(counter);
                    break;
                }

                counter++;
            }


        }
    }
}