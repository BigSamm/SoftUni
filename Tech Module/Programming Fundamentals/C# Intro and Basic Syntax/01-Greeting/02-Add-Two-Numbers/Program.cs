using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Add_Two_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var sum = a + b;
            Console.WriteLine("{1} + {2} = {0}", sum, a, b);
		}
	}
}
