using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] sumArr = new int[arr.Length / 2];

            int[] firstPart = new int[arr.Length / 4];
            int[] secondPart = new int[arr.Length / 4];
            int[] thirdPart = new int[arr.Length / 4];
            int[] fourthPart = new int[arr.Length / 4];

            for (int i = 0; i < arr.Length / 4; i++)
                firstPart[i] = arr[i];
            Array.Reverse(firstPart);
            for (int i = 0; i < arr.Length / 4; i++)
                secondPart[i] = arr[i + arr.Length / 4];
            for (int i = 0; i < arr.Length / 4; i++)
                thirdPart[i] = arr[i + arr.Length / 2];
            for (int i = 0; i < arr.Length / 4; i++)
                fourthPart[i] = arr[i + arr.Length - arr.Length / 4];
            Array.Reverse(fourthPart);

            for (int i = 0; i < arr.Length / 4; i++)
                sumArr[i] = firstPart[i] + secondPart[i];
            var x = 0;
            for (int i = arr.Length / 4; i < arr.Length / 2; i++)
            {
                sumArr[i] = thirdPart[x] + fourthPart[x];
                x++;
            }

            Console.WriteLine(String.Join(" ", sumArr));
        }
    }
}
