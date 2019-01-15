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
            var numsToAdd = input[0];
            var numsToRemove = input[1];
            var findNum = input[2];

            input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var queue = new Queue<int>();

            for (int i = 0; i < numsToAdd; i++)
            {
                queue.Enqueue(input[i]);
            }

            for (int i = 0; i < numsToRemove; i++)
            {
                queue.Dequeue();
            }

            if(queue.Contains(findNum))
            {
                Console.WriteLine("true");
            }
            else
            {
                if(queue.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    var min = int.MaxValue;
                    foreach (var num in queue)
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