using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        { 
                var skumriqCena = double.Parse(Console.ReadLine());
                var cacaCena = double.Parse(Console.ReadLine());
                var palamudKg = double.Parse(Console.ReadLine());
                var safridKg = double.Parse(Console.ReadLine());
                var midiKg = double.Parse(Console.ReadLine());

                var palamudCena = skumriqCena + skumriqCena * 0.6;              
                var palamudSuma = palamudKg * palamudCena;
                var safridCena = cacaCena + cacaCena * 0.8;
                var safridSuma = safridCena * safridKg;

                var midiCena = midiKg * 7.5;
                var sum = palamudSuma + safridSuma + midiCena;
                Console.WriteLine("{0:f2}",Math.Round(sum, 2));           
        }
    }
}
