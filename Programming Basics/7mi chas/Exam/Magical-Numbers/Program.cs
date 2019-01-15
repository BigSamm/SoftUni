using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magical_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 100000; i <= 999999; i++)
            {
                if ((i % 10) * ((i / 10) % 10) * ((i / 100) % 10) * ((i / 1000) % 10) * ((i / 10000) % 10) * (i / 100000) == n)
                    Console.Write(i + " ");
            }
        }
    }
}
