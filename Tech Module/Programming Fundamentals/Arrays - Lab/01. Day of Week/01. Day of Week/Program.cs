using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (num >= 1 && num <= 7)
            {
                Console.WriteLine(dayOfWeek[num - 1]);
            }
            else
                Console.WriteLine("Invalid Day!");
        }
    }
}
