using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayType = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var price = 0;

            if (age >= 0 && age <= 18)
            {
                if (dayType == "Weekday")
                    price = 12;
                if (dayType == "Weekend")
                    price = 15;
                if (dayType == "Holiday")
                    price = 5;
            }

            else if (age > 18 && age <= 64)
            {
                if (dayType == "Weekday")
                    price = 18;
                if (dayType == "Weekend")
                    price = 20;
                if (dayType == "Holiday")
                    price = 12;
            }

            else if (age > 64 && age <= 122)
            {
                if (dayType == "Weekday")
                    price = 12;
                if (dayType == "Weekend")
                    price = 15;
                if (dayType == "Holiday")
                    price = 10;
            }

            if(price == 0)
                Console.WriteLine("Error!");
            else
                Console.WriteLine("{0}$", price);


        }
    }
}
