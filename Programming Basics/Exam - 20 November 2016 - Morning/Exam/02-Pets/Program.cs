using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            var brDays = int.Parse(Console.ReadLine());
            var kgFood = int.Parse(Console.ReadLine());
            var dogFoodPerDay = double.Parse(Console.ReadLine());
            var catFoodPerDay = double.Parse(Console.ReadLine());
            var turtleFoodPerDay = double.Parse(Console.ReadLine());

            var dogFood = dogFoodPerDay * brDays;
            var catFood = catFoodPerDay * brDays;
            var turtleFood = (turtleFoodPerDay / 1000) * brDays;

            var allNeed = dogFood + catFood + turtleFood;

            if (allNeed <= kgFood) Console.WriteLine("{0} kilos of food left.", Math.Floor(kgFood - allNeed));
            else Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(allNeed - kgFood));


           
        }
    }
}
