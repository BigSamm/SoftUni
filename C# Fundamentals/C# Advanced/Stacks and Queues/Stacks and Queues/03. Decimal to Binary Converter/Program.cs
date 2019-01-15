using System;
using System.Collections.Generic;

namespace _03.Decimal_to_Binary_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            var decimalNum = int.Parse(Console.ReadLine());

            if(decimalNum == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                var stack = new Stack<int>();

                while(decimalNum > 0)
                {
                    stack.Push(decimalNum % 2);
                    decimalNum /= 2;
                }

                Console.WriteLine(String.Join("", stack));
            }

        }
    }
}