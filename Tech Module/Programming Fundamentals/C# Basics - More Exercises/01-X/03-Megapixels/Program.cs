using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Megapixels
{
    class Program
    {
        static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());
            var megapixels = (width * height) / 1000000.0;
            megapixels = Math.Round(megapixels, 1);
            Console.WriteLine($"{width}x{height} => {megapixels}MP");
        }
    }
}
