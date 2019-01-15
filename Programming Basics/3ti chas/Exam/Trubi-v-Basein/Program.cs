using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trubi_v_Basein
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = int.Parse(Console.ReadLine());
            var p1 = int.Parse(Console.ReadLine());
            var p2 = int.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var result = 0.0;
            var p11 = 0.0;
            var p22 = 0.0;
            double truba1 = h * p1;
            double truba2 = h * p2;
            double obshto = truba1 + truba2;

            if(obshto < v)
            {
                result = obshto / v * 100;
                p11 = Math.Truncate(truba1 / obshto * 100);
                p22 = Math.Truncate(truba2 / obshto * 100);
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", result, p11, p22);
            }
            else if(obshto > v)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, obshto - v);
            }


        }
    }
}
