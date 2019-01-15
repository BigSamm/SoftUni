using System;
using System.Collections.Generic;

namespace _05.Sequence_With_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());

            var queue = new Queue<long>();
            var allNums = new Queue<long>();
            allNums.Enqueue(num);
            
            for (int i = 0; i < 49; i += 3)
            {
                queue.Enqueue(num + 1);
                queue.Enqueue(2 * num + 1);
                queue.Enqueue(num + 2);

                num = queue.Dequeue();
                allNums.Enqueue(num);
            }

            foreach (var currentNum in queue)
            {
                allNums.Enqueue(currentNum);

                if (allNums.Count == 50)
                    break;
            }

            Console.WriteLine(String.Join(" ", allNums));
        }
    }
}