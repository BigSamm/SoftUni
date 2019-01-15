using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Cake_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            var br = 0;
            for (int i = 1; i <= 21; i++)
            {
                var ingredient = Console.ReadLine();

                if (ingredient == "Bake!")
                {
                    Console.WriteLine("Preparing cake with {0} ingredients.", br);
                    return;
                }
                else
                {
                    Console.WriteLine("Adding ingredient {0}.", ingredient);
                    br++;
                }
            }




        }
    }
}
