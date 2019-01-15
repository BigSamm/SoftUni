using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sort_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            var time = Console.ReadLine().Split().ToList();
            time.Sort();
            Console.WriteLine(string.Join(", ", time));
        }
    }
}
