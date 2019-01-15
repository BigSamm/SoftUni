using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleOf55Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = "";
            for (int i = 1; i <= 10; i++)
            {
                var b = "*";
                a += b;
                Console.WriteLine(a);
            }
        }
    }
}
