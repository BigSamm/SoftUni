using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var hour = int.Parse(Console.ReadLine());
            var min = int.Parse(Console.ReadLine());
            var bytes = double.Parse(Console.ReadLine());
            var width = int.Parse(Console.ReadLine());
            var height = int.Parse(Console.ReadLine());

            Console.WriteLine($"Name: DSC_{num:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{min:d2}");

            if(bytes < 1000)
            {
                bytes = Math.Round(bytes, 1);
                Console.WriteLine($"Size: {bytes}B");
            }
            else if (bytes >= 1000 && bytes < 1000000)
            {
                bytes /= 1000.0;
                bytes = Math.Round(bytes, 1);
                Console.WriteLine($"Size: {bytes}KB");
            }
            else if (bytes >= 1000000)
            {
                bytes /= 1000000.0;
                bytes = Math.Round(bytes, 1);
                Console.WriteLine($"Size: {bytes}MB");
            }

            Console.Write($"Resolution: {width}x{height} ");
            if (width > height) Console.WriteLine("(landscape)");
            else if (width < height) Console.WriteLine("(portrait)");
            else if (width == height) Console.WriteLine("(square)");
        }
    }
}
