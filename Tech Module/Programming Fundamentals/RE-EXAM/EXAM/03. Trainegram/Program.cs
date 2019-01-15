using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            //var locomotiveRegex = @"<\[[^\da-zA-Z]*?\]\.";
            //var wagonRegex = @"\.\[[a-zA-Z\d]*?\]\.";

            var trainRegex = @"^<\[[^\da-zA-Z]*?\]\.(\.\[[a-zA-Z\d]*?\]\.)*$";
            var allTrains = new List<string>();

            for (;;)
            {
                var input = Console.ReadLine();
                if (input == "Traincode!") break;

                var match = Regex.Match(input, trainRegex);
                if (match.Success)
                    allTrains.Add(match.ToString());
            }

            foreach (var train in allTrains)
            {
                Console.WriteLine(train);
            }
        }
    }
}
