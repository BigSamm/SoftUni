using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var times = int.Parse(Console.ReadLine());

            if (times <= 10)
            {
                for (int i = times; i <= 10; i++)
                {
                    Console.WriteLine("{0} X {1} = {2}", n, i, n*i);
                }
            }
            else
            {
                Console.WriteLine("{0} X {1} = {2}", n, times, n*times);
            }


        }
    }
}
