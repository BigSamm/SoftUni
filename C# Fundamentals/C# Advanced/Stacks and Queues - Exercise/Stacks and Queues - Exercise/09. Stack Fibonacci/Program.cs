using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Stack_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var fibNums = new Stack<long>();
            fibNums.Push(0);
            fibNums.Push(1);

            for (int i = 0; i < n - 1; i++)
            {
                var lastNum = fibNums.Pop();
                var numBeforeLast = fibNums.Peek();

                var nextNum = numBeforeLast + lastNum;
                fibNums.Push(lastNum);
                fibNums.Push(nextNum);
            }

            Console.WriteLine(fibNums.Pop());
        }
    }
}