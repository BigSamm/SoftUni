using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var startEnd = n;
            var mid = n * 2 - 1;

            Console.Write(new string('.', n + 1));
            Console.Write(new string('_', 2 * n + 1));
            Console.WriteLine(new string('.', n + 1));
            
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', startEnd));
                Console.Write("//");
                Console.Write(new string('_', mid));
                Console.Write(@"\\");
                Console.WriteLine(new string('.', startEnd));
                startEnd--;
                mid += 2;
            }

            Console.Write("//");
            Console.Write(new string('_', 2 * n - 3));
            Console.Write("STOP!");
            Console.Write(new string('_', 2 * n - 3));
            Console.WriteLine(@"\\");

            startEnd = 0;
            mid = 4 * n - 1; 
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string('.', startEnd));
                Console.Write(@"\\");
                Console.Write(new string('_', mid));
                Console.Write("//");
                Console.WriteLine(new string('.', startEnd));
                startEnd++;
                mid -= 2;
            }

          



        }
    }
}
