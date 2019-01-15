using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var result = "";

            try
            {
                var a = sbyte.Parse(n);
                result += "* sbyte \n";
            }
            catch
            { }

            try
            {
                var b = byte.Parse(n);
                result += "* byte \n";
            }
            catch
            { }

            try
            {
                var c = short.Parse(n);
                result += "* short \n";
            }
            catch
            { }

            try
            {
                var c = ushort.Parse(n);
                result += "* ushort \n";
            }
            catch
            { }

            try
            {
                var c = int.Parse(n);
                result += "* int \n";
            }
            catch
            { }

            try
            {
                var c = uint.Parse(n);
                result += "* uint \n";
            }
            catch
            { }

            try
            {
                var c = long.Parse(n);
                result += "* long";
            }
            catch
            {
                Console.WriteLine($"{n} can't fit in any type");
                return;
            }

            Console.WriteLine($"{n} can fit in: \n" + result);


        }
    }
}
