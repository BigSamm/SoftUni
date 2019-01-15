using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var timer = new Stopwatch();
            timer.Start();
            long count = 0;
            for (int i = 0; i < 500000000; i++)
            {
                count++;
            }
            Console.WriteLine(timer.Elapsed);
        }
    }
}
