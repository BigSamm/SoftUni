using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelenchukova_Borsa
{
    class Program
    {
        static void Main(string[] args)
        {
            var cena_zel = double.Parse(Console.ReadLine());
            var cena_plod = double.Parse(Console.ReadLine());
            var kg_zel = int.Parse(Console.ReadLine());
            var kg_plod = int.Parse(Console.ReadLine());
            var zel = 0.0;
            var plod = 0.0;
            var result = 0.0;

            zel = kg_zel * cena_zel;
            plod = kg_plod * cena_plod;
            result = (zel + plod) / 1.94;

            Console.WriteLine(result);

            // 4 min
        }
    }
}
