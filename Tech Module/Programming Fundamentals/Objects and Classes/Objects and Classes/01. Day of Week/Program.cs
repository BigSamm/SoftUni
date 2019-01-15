using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayText = Console.ReadLine();
            var dayOfWeek = DateTime.ParseExact(dayText, "d-M-yyyy",
                CultureInfo.InvariantCulture);
            Console.WriteLine(dayOfWeek.DayOfWeek);
        }
    }
}
