using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var children = Console.ReadLine().Split(' ').ToArray();
            var toss = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(children);

            while(queue.Count > 1)
            {
                for (int i = 0; i < toss - 1; i++)
                {
                    var currentChild = queue.Dequeue();
                    queue.Enqueue(currentChild);
                }

                var removedChild = queue.Dequeue();
                Console.WriteLine($"Removed {removedChild}");
            }

            var lastChild = queue.Dequeue();
            Console.WriteLine($"Last is {lastChild}");
        }
    }
}