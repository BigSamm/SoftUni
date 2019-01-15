using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var eps = 0.000001;
            
            if (Math.Abs(a-b) < eps)
                Console.WriteLine("True");
            else if (Math.Abs(a-b) >= eps)
                Console.WriteLine("False");





                        
        }
    }
}
