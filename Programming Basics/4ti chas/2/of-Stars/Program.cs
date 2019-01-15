using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            int i;

            Console.Write(new string(' ', a - 1));
            Console.WriteLine(new string('*', a));
            for(i = 0; i < a - 2; i++)
            {
                Console.Write(new string(' ', a - 1));
                Console.Write("*");
                Console.Write(new string(' ', a - 2));
                Console.WriteLine("*");
            }


            Console.Write(new string('*', a));
            Console.Write(new string(' ', a - 2));
            Console.WriteLine(new string('*', a));
            for (i = 0; i < a - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string(' ', (a - 2) + (a - 2) + a));
                Console.WriteLine("*");
            }
            Console.Write(new string('*', a));
            Console.Write(new string(' ', a - 2));
            Console.WriteLine(new string('*', a));


            for (i = 0; i < a - 2; i++)
            {
                Console.Write(new string(' ', a - 1));
                Console.Write("*");
                Console.Write(new string(' ', a - 2));
                Console.WriteLine("*");
            }
            Console.Write(new string(' ', a - 1));
            Console.WriteLine(new string('*', a));
            

        }
    }
}
