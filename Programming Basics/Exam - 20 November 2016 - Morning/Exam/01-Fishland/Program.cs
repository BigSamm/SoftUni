using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            var skumriqCena = double.Parse(Console.ReadLine());
            var cacaCena = double.Parse(Console.ReadLine());
            var kgPalamud = double.Parse(Console.ReadLine());
            var kgSafrid = double.Parse(Console.ReadLine());
            var kgMidi = int.Parse(Console.ReadLine());

            var cenaPalamud = skumriqCena + skumriqCena * .6;
            var cenaSafrid = cacaCena + cacaCena * .8;
            var cenaMidi = 7.5;

            var result = kgMidi * cenaMidi + kgPalamud * cenaPalamud + kgSafrid * cenaSafrid;
            Console.WriteLine("{0:f2}", result);



        }
    }
}
// 20:18