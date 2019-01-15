using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var location = "";
            var a = "";

            if (budget <= 1000.0)
            {
                if (season == "Summer")
                {
                    location = "Alaska";
                    budget = budget * .65;
                }
                if (season == "Winter")
                {
                    location = "Morocco";
                    budget = budget * .45;
                }
                a = "Camp";
            }

            if (budget > 1000.0 && budget <= 3000.0)
            {
                if (season == "Summer")
                {
                    location = "Alaska";
                    budget = budget * .8;
                }
                if (season == "Winter")
                {
                    location = "Morocco";
                    budget = budget * .6;
                }
                a = "Hut";
            }

            if (budget > 3000.0)
            {
                if (season == "Summer")
                {
                    location = "Alaska";
                    budget = budget * .9;
                }
                if (season == "Winter")
                {
                    location = "Morocco";
                    budget = budget * .9;
                }
                a = "Hotel";
            }

            Console.WriteLine("{0} - {1} - {2:f2}" , location, a, budget);



        }
    }
}
