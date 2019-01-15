using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            var guests = int.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var kiloBerriesPrice = double.Parse(Console.ReadLine());

            var sets = Math.Ceiling(guests / 6.0);
            var needCash = sets * (2 * bananaPrice + 4 * eggPrice + 0.2 * kiloBerriesPrice);

            if(needCash <= cash)
                Console.WriteLine($"Ivancho has enough money - it would cost {needCash:f2}lv.");
            else
                Console.WriteLine($"Ivancho will have to withdraw money - he will {needCash - cash:f2}lv more.");
        }
    }
}
