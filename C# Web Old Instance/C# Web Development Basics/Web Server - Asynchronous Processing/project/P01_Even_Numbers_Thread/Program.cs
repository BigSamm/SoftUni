namespace P01_Even_Numbers_Thread
{
    using System;
    using System.Linq;
    using System.Threading;

    class Program
    {
        static void Main()
        {
            int[] args = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int start = args[0];
            int end = args[1];

            Thread evens = new Thread(() => PrintEvenNumbers(start, end));
            evens.Start();
            evens.Join();

            Console.WriteLine("Thread finished work");
        }

        private static void PrintEvenNumbers(int start, int end)
        {
            for (int num = start; num <= end; num++)
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
            }
        }
    }
}
