using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            var hrizantemiBr = int.Parse(Console.ReadLine());
            var rosesBr = int.Parse(Console.ReadLine());
            var laletaBr = int.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var praznik = Console.ReadLine().ToUpper();

            var money = 0.0;
            var hrizantemiPrice = 0.0;
            var rosesPrice = 0.0;
            var laletaPrice = 0.0;

            if (season == "Spring" || season == "Summer")
            {
                hrizantemiPrice = 2.0;
                rosesPrice = 4.1;
                laletaPrice = 2.5;
            }
            else if (season == "Autumn" || season == "Winter")
            {
                hrizantemiPrice = 3.75;
                rosesPrice = 4.5;
                laletaPrice = 4.15;
            }

            money = hrizantemiBr * hrizantemiPrice + rosesBr * rosesPrice + laletaBr * laletaPrice;

            if (praznik == "Y") money += money * 0.15;
            if (season == "Spring" && laletaBr > 7) money -= money * .05;
            if (season == "Winter" && rosesBr >= 10) money -= money * .1;
            if (hrizantemiBr + rosesBr + laletaBr > 20) money -= money * .2;

            money += 2;

            Console.WriteLine("{0:f2}",money);




        }
    }
}
