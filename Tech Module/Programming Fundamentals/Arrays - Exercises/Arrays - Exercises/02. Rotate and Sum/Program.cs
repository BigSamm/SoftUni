using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var k = int.Parse(Console.ReadLine());
            int[] sumArr = new int[arr.Length];

            for (int h = 0; h < k; h++)
            {
                RotateArr(arr);
                for (int i = 0; i < arr.Length; i++)
                {
                    sumArr[i] += arr[i];
                }
            }
            Console.WriteLine(String.Join(" ", sumArr));
        }

        static void RotateArr(int[] arr)
        {
            var lastElement = arr[arr.Length - 1];
            for (int i = arr.Length - 1; i > 0; i--)
            {
                arr[i] = arr[i - 1];
            }
            arr[0] = lastElement;
        }
    }
}
