using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            var month = Console.ReadLine();
            var nights = int.Parse(Console.ReadLine());

            var apartment = 0.0;
            var studio = 0.0;

            if (month == "May" || month == "October")
            {
                studio = 50 * nights;
                apartment = 65 * nights;
                if (nights > 7 && nights <= 14)
                    studio = studio - studio * 0.05;
                else if (nights > 14)
                    studio = studio - studio * 0.3;
                
            }


            else if (month == "June" || month == "September")
            {
                studio = 75.20 * nights;
                apartment = 68.70 * nights;
                if (nights > 14)
                    studio = studio - studio * 0.2;
                
            }


            else if (month == "July" || month == "August")
            {
                studio = 76 * nights;
                apartment = 77 * nights;
            }

            if (nights > 14)
            {
                apartment = apartment - apartment * 0.1;
            }

            Console.WriteLine("Apartment: {0:f2} lv.", apartment);
            Console.WriteLine("Studio: {0:f2} lv.", studio);

        }
    }
}
