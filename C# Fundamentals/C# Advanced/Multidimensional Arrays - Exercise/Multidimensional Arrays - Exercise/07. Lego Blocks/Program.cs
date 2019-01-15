using System;

namespace _07.Lego_Blocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            string[][] firstArray = GetJaggedArray(n);
            string[][] secondArray = GetJaggedArray(n);

            for (int i = 0; i < secondArray.Length; i++)
            {
                Array.Reverse(secondArray[i]);
            }

            var bothArraysCols = firstArray[0].Length + secondArray[0].Length;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if(firstArray[i].Length + secondArray[i].Length != bothArraysCols)
                {
                    DoNotFit(firstArray, secondArray);
                }
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.WriteLine("[" + String.Join(", ", firstArray[i]) + ", " + String.Join(", ", secondArray[i]) + "]");
            }
        }

        private static void DoNotFit(string[][] firstArray, string[][] secondArray)
        {
            var counter = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                counter += firstArray[i].Length + secondArray[i].Length;
            }

            Console.WriteLine($"The total number of cells is: {counter}");
            Environment.Exit(0);
        }

        private static string[][] GetJaggedArray(int n)
        {
            string[][] jaggedArray = new string[n][];

            for (int i = 0; i < n; i++)
            {
                var nums = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                jaggedArray[i] = nums;
            }

            return jaggedArray;
        }
    }
}