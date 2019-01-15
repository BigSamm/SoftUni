using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energyIn100 = double.Parse(Console.ReadLine());
            var sugarIn100 = double.Parse(Console.ReadLine());

            double energy = (volume / 100.0) * energyIn100;
            double sugars = (volume / 100.0) * sugarIn100;


            Console.WriteLine("{0}ml {1}:", volume, name);
            Console.WriteLine("{0}kcal, {1}g sugars", energy, sugars);
        }
    }
}
