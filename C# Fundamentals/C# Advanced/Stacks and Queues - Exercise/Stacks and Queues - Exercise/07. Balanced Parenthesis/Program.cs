using System;
using System.Collections.Generic;

namespace _07.Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            if(input.Length % 2 == 1)
            {
                NotBalanced();
            }

            var openingBrackets = new[] { '(', '{', '[' };
            var closingBrackets = new[] { ')', '}', ']' };
            
            var stack = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                if(Array.Exists(openingBrackets, b => b == currentChar))
                {
                    stack.Push(currentChar);
                }
                else
                {
                    if (Array.IndexOf(closingBrackets, currentChar) != Array.IndexOf(openingBrackets, stack.Pop()))
                    {
                        NotBalanced();
                    }
                }
            }

            Console.WriteLine("YES");
        }

        private static void NotBalanced()
        {
            Console.WriteLine("NO");
            Environment.Exit(0);
        }
    }
}