using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Practice_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = sbyte.Parse(Console.ReadLine());
            var b = byte.Parse(Console.ReadLine());
            var c = short.Parse(Console.ReadLine());
            var d = ushort.Parse(Console.ReadLine());
            var e = uint.Parse(Console.ReadLine());
            var f = int.Parse(Console.ReadLine());
            var g = long.Parse(Console.ReadLine());

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
        }
    }
}
