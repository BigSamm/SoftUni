using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = double.Parse(Console.ReadLine());
            var power = double.Parse(Console.ReadLine());
            var result = RaiseToPower(num, power);
            Console.WriteLine(result);
        }

        static double RaiseToPower(double num, double power)
        {
            return Math.Pow(num, power);
        }
    }
}
