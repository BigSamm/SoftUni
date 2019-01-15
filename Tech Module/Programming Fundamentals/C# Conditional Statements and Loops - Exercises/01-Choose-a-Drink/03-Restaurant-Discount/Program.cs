using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            var groupSize = int.Parse(Console.ReadLine());
            var package = Console.ReadLine();

            var price = 0.0;
            var hall = "";

            if (groupSize <= 50)
            {
                hall = "Small Hall";
                price += 2500;
                if (package == "Normal")
                    price += 500;
                if (package == "Gold")
                    price += 750;
                if (package == "Platinum")
                    price += 1000;
            }

            else if (groupSize > 50 && groupSize <= 100)
            {
                hall = "Terrace";
                price += 5000;
                if (package == "Normal")
                    price += 500;
                if (package == "Gold")
                    price += 750;
                if (package == "Platinum")
                    price += 1000;
            }

            else if (groupSize > 100 && groupSize <= 120)
            {
                hall = "Great Hall";
                price += 7500;
                if (package == "Normal")
                    price += 500;
                if (package == "Gold")
                    price += 750;
                if (package == "Platinum")
                    price += 1000;
            }
            else if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            if (package == "Normal")
                price -= price * 0.05;
            else if (package == "Gold")
                price -= price * 0.1;
            else if (package == "Platinum")
                price -= price * 0.15;

            Console.WriteLine("We can offer you the {0}", hall);
            Console.WriteLine("The price per person is {0:f2}$", price / groupSize);


        }
    }
}
