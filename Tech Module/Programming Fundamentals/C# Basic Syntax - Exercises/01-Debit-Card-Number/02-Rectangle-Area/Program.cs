using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var height = float.Parse(Console.ReadLine());
            var width = float.Parse(Console.ReadLine());

            Console.WriteLine("{0:f2}", height*width);
        }
    }
}
