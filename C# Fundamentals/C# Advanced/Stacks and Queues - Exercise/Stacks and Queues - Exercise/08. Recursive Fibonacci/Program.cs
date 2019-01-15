using System;
using System.Collections.Generic;

namespace _08.Recursive_Fibonacci
{
    class Program
    {
        public static long[] my_memo;

        static void Main()
        {
            long k = long.Parse(Console.ReadLine());
            my_memo = new long[k + 1];

            Console.WriteLine($"{FibWithMemo(k)}");
        }

        static long FibWithMemo(long counter_inside)
        {
            if (my_memo[counter_inside] != 0)
                return my_memo[counter_inside];

            if (counter_inside == 0) return 0;
            if (counter_inside == 1) return 1;
            my_memo[counter_inside] = FibWithMemo(counter_inside - 1) + FibWithMemo(counter_inside - 2);
            return my_memo[counter_inside];
        }
    }
}