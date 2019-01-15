using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division_without_Residue
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p1 = 0.0;
            var p2 = 0.0;
            var p3 = 0.0;

            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0) p1++;
                if (num % 3 == 0) p2++;
                if (num % 4 == 0) p3++;
            }

            Console.WriteLine("{0:f2}%", Math.Round(p1 / n * 100 , 2));
            Console.WriteLine("{0:f2}%", Math.Round(p2 / n * 100 , 2));
            Console.WriteLine("{0:f2}%", Math.Round(p3 / n * 100 , 2));
        }
    }
}
