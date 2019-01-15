using System;

namespace _04.Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            long[][] array = CreateArray();
            array[0][0] = 1;

            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    try
                    {
                        array[i][j] = array[i - 1][j] + array[i - 1][j - 1];
                    }
                    catch
                    {
                        if (j == 0)
                            array[i][j] = array[i - 1][j];
                        else
                            array[i][j] = array[i - 1][j - 1];
                    }
                }
            }

            PrintArray(array);
        }

        private static void PrintArray(long[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(String.Join(" ", array[i]));
            }
        }

        private static long[][] CreateArray()
        {
            var n = int.Parse(Console.ReadLine());

            long[][] array = new long[n][];

            int[] sizes = new int[n];
            for (int i = 0; i < sizes.Length; i++)
            {
                sizes[i] = i;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new long[i + 1];
            }

            return array;
        }
    }
}