using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var hex = Convert.ToString(n, 16);
            hex = hex.ToUpper();
            var binary = Convert.ToString(n, 2);
            Console.WriteLine(hex);
            Console.WriteLine(binary);
        }
    }
}
