using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var chinese = double.Parse(Console.ReadLine());
            var com = double.Parse(Console.ReadLine());
            var result = 0.0;
            bitcoin *= 1168;
            chinese = (chinese * 0.15) * 1.76;
            var euro = (bitcoin + chinese) / 1.95;
            com = com / 100;
            result = euro - (com * euro);
            Console.WriteLine(result);

            // 9 min
        }
    }
}
