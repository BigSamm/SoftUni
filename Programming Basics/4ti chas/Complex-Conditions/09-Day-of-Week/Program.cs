using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = Console.ReadLine();
            var d = "";
            
            switch (day)
            {
                case "1": d = "Monday"; break;
                case "2": d = "Tuesday"; break;
                case "3": d = "Wednesday"; break;
                case "4": d = "Thursday"; break;
                case "5": d = "Friday"; break;
                case "6": d = "Saturday"; break;
                case "7": d = "Sunday"; break;
            }

            if (day == "1" || day == "2" || day == "3" || day == "4" || day == "5" || day == "6" || day == "7")
                Console.WriteLine(d);
            else Console.WriteLine("error");
        }
    }
}
