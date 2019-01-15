using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var stack = new Stack<string>(input.Reverse());

            while(stack.Count > 1)
            {
                var leftOperand = int.Parse(stack.Pop());
                var @operator = stack.Pop();
                var rightOperand = int.Parse(stack.Pop());

                var result = 0;
                switch(@operator)
                {
                    case "+":
                        result = leftOperand + rightOperand;
                        break;
                    case "-":
                        result = leftOperand - rightOperand;
                        break;
                }

                stack.Push(result.ToString());
            }

            Console.WriteLine(stack.Pop());
        }
    }
}