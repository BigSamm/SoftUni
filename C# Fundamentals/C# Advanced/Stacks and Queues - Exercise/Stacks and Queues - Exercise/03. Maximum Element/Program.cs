using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Maximum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();
            var max = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                if(input[0] == 1)
                {
                    var num = input[1];
                    stack.Push(num);
                    if (num > max)
                    {
                        max = num;
                    }
                }
                else if (stack.Count > 0)
                {
                    if (input[0] == 2)
                    {
                        if (max == stack.Pop())
                        {
                            max = int.MinValue;
                            foreach (var item in stack)
                            {
                                if (item > max)
                                    max = item;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(max);
                    }
                }
            }
        }
    }
}