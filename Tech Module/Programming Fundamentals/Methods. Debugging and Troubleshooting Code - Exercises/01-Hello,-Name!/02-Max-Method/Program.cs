using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var third = int.Parse(Console.ReadLine());
            var max = GetMax(first, second, third);
            Console.WriteLine(max);
        }

        static int GetMax(int first, int second, int third)
        {
            int max = 0;

            if (first >= Math.Max(second, third))
                max = first;
            else if (second >= Math.Max(first, third))
                max = second;
            else if (third >= Math.Max(first, second))
                max = third;

            return max;
        }
    }
}
