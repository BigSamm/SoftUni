using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = double.Parse(Console.ReadLine());
            var w = double.Parse(Console.ReadLine());
            var result = 0.0;

            h = Math.Floor(h / 1.2);
            w = Math.Floor((w - 1) / 0.7);
            result = Math.Floor((h * w) - 3);
            Console.WriteLine(result);

            // 3-5 min
        }
    }
}
