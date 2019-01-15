using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
                var n = int.Parse(Console.ReadLine());
                var p1 = 0.0;
                var p2 = 0.0;
                var p3 = 0.0;
                var p4 = 0.0;
                var p5 = 0.0;

                for (int i = 0; i < n; i++)
                {
                    var num = int.Parse(Console.ReadLine());
                    if (num < 200) p1++;
                    else if (num >= 200 && num <= 399) p2++;
                    else if (num >= 400 && num <= 599) p3++;
                    else if (num >= 600 && num <= 799) p4++;
                    else if (num >= 800) p5++;
                }

                Console.WriteLine("{0:f2}%" , Math.Round(p1 / n * 100.0, 2));
                Console.WriteLine("{0:f2}%" , Math.Round(p2 / n * 100.0, 2));
                Console.WriteLine("{0:f2}%" , Math.Round(p3 / n * 100.0, 2));
                Console.WriteLine("{0:f2}%" , Math.Round(p4 / n * 100.0, 2));
                Console.WriteLine("{0:f2}%" , Math.Round(p5 / n * 100.0, 2));
            
        }
    }
}
