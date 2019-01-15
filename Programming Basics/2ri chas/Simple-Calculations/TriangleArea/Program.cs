using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("h= ");
            var h = double.Parse(Console.ReadLine());
            var area = Math.Round((a * h) / 2, 2);
            Console.Write("area= ");
            Console.WriteLine(area);
        }
    }
}
