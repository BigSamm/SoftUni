using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var day_night = Console.ReadLine();
            var result = 0.0;

            if(n < 20)
            {
                switch (day_night)
                {
                    case "day": result = 0.7 + (n * .79); break;
                    case "night": result = 0.7 + (n * .9); break;
                }
            }
            else if(n >= 20 && n < 100)
            {
                result = n * .09;
            }
            else if(n >= 100)
            {
                result = n * .06;
            }
            Console.WriteLine(result);
        }
    }
}
