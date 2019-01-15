using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Before: \n" +
                              $"a = {a} \n" +
                              $"b = {b}");
            var aOld = a;
            a = b;
            b = aOld;
            Console.WriteLine($"After: \n" +
                              $"a = {a} \n" +
                              $"b = {b}");
        }
    }
}
