using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dnevna_Pechalba
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = double.Parse(Console.ReadLine());
            var kurs = double.Parse(Console.ReadLine());

            var god_dohod = (12 * n * m) + (2.5 * n * m);
            var chist_god_dohod = god_dohod - (god_dohod * 0.25);
            chist_god_dohod *= kurs;
            var result = chist_god_dohod / 365;
            Console.WriteLine(Math.Round(result, 2));

            // 7 min
        }
    }
}
