using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Byte_Flip
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split()
                .Where(x => x.Length == 2)
                .Select(x => new string(x.Reverse().ToArray()))
                .Reverse()
                .Select(x => Convert.ToChar(Convert.ToInt32(x, 16)))
                .ToList();
            Console.WriteLine(string.Join("", input));


        }
    }
}
