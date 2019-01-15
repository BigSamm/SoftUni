using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grab_and_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var num = long.Parse(Console.ReadLine());
            Array.Reverse(arr);
            long sum = 0;
            var check = false;
            for (long i = 0; i < arr.Length; i++)
            {
                if (arr[i] == num)
                {
                    check = true;
                    for (i = i+1; i < arr.Length; i++)
                    {
                        sum += arr[i];
                    }
                }
            }
            if (check)
            {
                Console.WriteLine(sum);
            }
            else
                Console.WriteLine("No occurrences were found!");
        }
    }
}
