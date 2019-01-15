using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Odd_or_Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var oddsum = 0.0;
            var oddmin = 1000000000.0;
            var oddmax = -1000000000.0;
            var evensum = 0.0;
            var evenmin = 1000000000.0;
            var evenmax = -1000000000.0;

            for (int i = 1; i <= n; i++)
			{
			    if(i % 2 == 0)
                {
                    var even = double.Parse(Console.ReadLine());
                    if(even < evenmin) evenmin = even;
                    if(even > evenmax) evenmax = even;
                    evensum += even;
                }
                else
                {
                    var odd = double.Parse(Console.ReadLine());
                    if(odd < oddmin) oddmin = odd;
                    if(odd > oddmax) oddmax = odd;
                    oddsum += odd;
                }
			}
            
            Console.WriteLine("OddSum=" + oddsum);
            if (oddmin == 1000000000.0) Console.WriteLine("OddMin no");
            else Console.WriteLine("OddMin=" + oddmin);
            if (oddmax == -1000000000.0) Console.WriteLine("OddMax no");
            else Console.WriteLine("OddMax=" + oddmax);
            Console.WriteLine("EvenSum=" + evensum);
            if (evenmin == 1000000000.0) Console.WriteLine("EvenMin no");
            else Console.WriteLine("EvenMin=" + evenmin);
            if (evenmax == -1000000000.0) Console.WriteLine("EvenMax no");
            else Console.WriteLine("EvenMax=" + evenmax);

            // 34 min
        }
    }
}
