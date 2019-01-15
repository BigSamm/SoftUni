using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Battles
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons1 = int.Parse(Console.ReadLine());
            var pokemons2 = int.Parse(Console.ReadLine());
            var maxfights = int.Parse(Console.ReadLine());
            var num1 = 1;
            var num2 = 1;
            var br = 0;

            for (int i = 1; i <= pokemons1; i++)
            {
                for (int j = 1; j <= pokemons2; j++)
                {
                    Console.Write("({0} <-> {1}) ", num1, num2);
                    num2++;
                    br++;
                    if (br == maxfights) return;
                }
                num2 = 1;
                num1++;
            }



        }
    }
}
