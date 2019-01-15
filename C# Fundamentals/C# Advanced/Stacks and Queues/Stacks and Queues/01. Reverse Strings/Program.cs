using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var stack = new Stack<char>(input);

            foreach (var letter in stack)
            {
                Console.Write(letter);
            }
            Console.WriteLine();
        }
    }
}