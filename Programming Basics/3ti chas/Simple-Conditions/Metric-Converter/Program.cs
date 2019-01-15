using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = double.Parse(Console.ReadLine());
            string from = Console.ReadLine().ToLower();
            string to = Console.ReadLine().ToLower();
                       
            if (from == "m") size *= 1;
            else if (from == "mm") size /= 1000;
            else if (from == "cm") size /= 100;
            else if (from == "mi") size /= 0.000621371192;
            else if (from == "in") size /= 39.3700787;
            else if (from == "km") size /= 0.001;
            else if (from == "ft") size /= 3.2808399;
            else if (from == "yd") size /= 1.0936133;

            if (to == "m") size *= 1;
            else if (to == "mm") size *= 1000;
            else if (to == "cm") size *= 100;
            else if (to == "mi") size *= 0.000621371192;
            else if (to == "in") size *= 39.3700787;
            else if (to == "km") size *= 0.001;
            else if (to == "ft") size *= 3.2808399;
            else if (to == "yd") size *= 1.0936133;
         
            Console.WriteLine(size + " " + to);
        }
    }
}
