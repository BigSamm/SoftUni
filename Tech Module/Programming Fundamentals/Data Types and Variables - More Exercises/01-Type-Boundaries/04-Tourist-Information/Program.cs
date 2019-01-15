using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            var imperialUnit = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());

            double result = 0.0;
            var metricUnit = "";

            if (imperialUnit == "miles")
            {
                metricUnit = "kilometers";
                result = (value * 1.6);
            }
            else if (imperialUnit == "inches")
            {
                metricUnit = "centimeters";
                result = (value * 2.54);
            }
            else if (imperialUnit == "feet")
            {
                metricUnit = "centimeters";
                result = (value * 30.0);
            }
            else if (imperialUnit == "yards")
            {
                metricUnit = "meters";
                result = (value * .91);
            }
            else if (imperialUnit == "gallons")
            {
                metricUnit = "liters";
                result = (value * 3.8);
            }

            Console.WriteLine($"{value} {imperialUnit} = {result:f2} {metricUnit}");

        }
    }
}
