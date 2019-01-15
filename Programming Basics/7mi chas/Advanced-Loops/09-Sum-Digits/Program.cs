using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 0;

            while(n > 0)
            {
                num += n % 10;
                n /= 10;
            }
            Console.WriteLine(num);

        }
    }
}
