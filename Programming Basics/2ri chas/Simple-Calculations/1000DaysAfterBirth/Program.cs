using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime result = DateTime.ParseExact(dateString, format, CultureInfo.InvariantCulture);
            DateTime answer = result.AddDays(999);
            Console.WriteLine(answer.ToString(format));


        }
    }
}
