using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var biggestKegModel = "";
            var biggestKegVol = 0.0;

            for (int i = 0; i < n; i++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());
                

                var volume = Math.PI * radius * radius * height;

                if (volume > biggestKegVol)
                {
                    biggestKegVol = volume;
                    biggestKegModel = model;
                }
             }

            Console.WriteLine(biggestKegModel);

        }
    }
}
