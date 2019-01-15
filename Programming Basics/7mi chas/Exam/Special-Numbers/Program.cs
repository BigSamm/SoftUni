using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                if (i % 10 != 0 &&
                    (i / 10) % 10 != 0 &&
                    (i / 100) % 10 != 0 &&
                    i / 1000 != 0 &&
                    n % (i % 10) == 0 &&
                    n % ((i / 10) % 10) == 0 &&
                    n % ((i / 100) % 10) == 0 &&
                    n % (i / 1000) == 0 )
                { Console.Write(i + " "); }

            }





        }
    }
}
