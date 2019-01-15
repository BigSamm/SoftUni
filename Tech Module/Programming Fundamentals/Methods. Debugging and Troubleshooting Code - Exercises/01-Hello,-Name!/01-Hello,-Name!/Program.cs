using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Hello__Name_
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = GetName();
            Console.WriteLine($"Hello, {name}!");
        }

        static string GetName()
        {
            var name = Console.ReadLine();
            return name;
        }
    }
}
