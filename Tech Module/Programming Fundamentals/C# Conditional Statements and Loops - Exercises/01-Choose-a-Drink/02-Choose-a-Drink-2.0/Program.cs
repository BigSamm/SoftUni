using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Choose_a_Drink_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var profession = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            if (profession == "Athlete")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * .7);
            }
            else if (profession == "Businessman" || profession == "Businesswoman")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity);
            }
            else if (profession == "SoftUni Student")
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * 1.7);
            }
            else
            {
                Console.WriteLine("The {0} has to pay {1:f2}.", profession, quantity * 1.2);
            }


        }
    }
}
