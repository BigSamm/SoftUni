using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine().Split(' ').ToArray();
            string[] secondArr = Console.ReadLine().Split(' ').ToArray();

            var shorterArr = Math.Min(firstArr.Length, secondArr.Length);
            var largerArr = Math.Max(firstArr.Length, secondArr.Length);
            var rigthCount = 0;
            var leftCount = 0;

            for (int i = 0; i < shorterArr; i++)
            {
                if (firstArr[i] == secondArr[i])
                    leftCount++;
            }
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            for (int i = 0; i < shorterArr; i++)
            {
                if (firstArr[i] == secondArr[i])
                    rigthCount++;
            }

            Console.WriteLine(Math.Max(leftCount, rigthCount));
        }
    }
}
