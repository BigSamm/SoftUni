using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
                var n = Console.ReadLine();
                var a = Convert.ToInt32($"{n}", 16);
                Console.WriteLine(a);
        }
    }
}
