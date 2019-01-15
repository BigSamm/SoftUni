using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var numsToPush = input[0];
            var numsTopop = input[1];
            var findNum = input[2];

            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var stack = new Stack<int>(input);

            for (int i = 0; i < numsTopop; i++)
            {
                stack.Pop();
            }

            if(stack.Contains(findNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                if(stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    var min = int.MaxValue;
                    foreach (var num in stack)
                    {
                        if (num < min)
                            min = num;
                    }
                    Console.WriteLine(min);
                }
            }
        }
    }
}