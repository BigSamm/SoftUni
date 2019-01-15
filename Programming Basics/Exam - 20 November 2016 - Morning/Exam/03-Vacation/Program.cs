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
            var brOld = int.Parse(Console.ReadLine());
            var brChild = int.Parse(Console.ReadLine());
            var brNights = int.Parse(Console.ReadLine());
            var transport = Console.ReadLine();
            var money = 0.0;

            if (transport == "train" && brOld + brChild>= 50)
            {
                money += brOld * (24.99 * 0.5) * 2;
                money += brChild * (14.99 * 0.5) * 2;
            }

            else if (transport == "train")
            {
                money += (brOld * 24.99 + brChild * 14.99) * 2;
            }

            else if (transport == "bus")
            {
                money += (brOld * 32.5 + brChild * 28.5) * 2;
            }

            else if (transport == "boat")
            {
                money += (brOld * 42.99 + brChild * 39.99) * 2;
            }

            else if (transport == "airplane")
            {
                money += (brOld * 70.0 + brChild * 50.0) * 2;
            }

            money += brNights * 82.99;
            var commision = money * 0.1;

            var result = money + commision;

            Console.WriteLine("{0:f2}", result);

        }
    }
}
