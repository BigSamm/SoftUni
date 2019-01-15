using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Stop_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = int.Parse(Console.ReadLine());
            var end = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());

            for (var i = end; i >= start; i--)
            {
                if (i == stop && i % 2 == 0 && i % 3 == 0) return;
                if (i % 2 == 0 && i % 3 == 0) Console.Write(i + " ");
            }
        }
    }
}
