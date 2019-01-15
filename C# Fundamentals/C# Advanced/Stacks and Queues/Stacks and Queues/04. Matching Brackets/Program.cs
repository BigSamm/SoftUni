using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var openingBrackets = new Stack<int>();

            for (int index = 0; index < input.Length; index++)
            {
                if(input[index] == '(')
                {
                    openingBrackets.Push(index);
                }
                else if(input[index] == ')')
                {
                    var startIndex = openingBrackets.Pop();
                    var length = index - startIndex + 1;
                    Console.WriteLine(input.Substring(startIndex, length));
                }
            }
        }
    }
}