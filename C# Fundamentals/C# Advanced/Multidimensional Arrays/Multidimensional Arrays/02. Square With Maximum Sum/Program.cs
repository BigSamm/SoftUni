using System;
using System.Linq;

namespace _02.Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = CreateMatrix();

            var maxSum = int.MinValue;
            var maxRow = 0;
            var maxCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    var currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        maxRow = row;
                        maxCol = col;
                    }
                }
            }

            Console.WriteLine(matrix[maxRow, maxCol] + " " + matrix[maxRow, maxCol + 1]);
            Console.WriteLine(matrix[maxRow + 1, maxCol] + " " + matrix[maxRow + 1, maxCol + 1]);
            Console.WriteLine(maxSum);
        }

        private static int[,] CreateMatrix()
        {
            var rowsAndCols = ReadFromConsole();
            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputNums = ReadFromConsole();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputNums[col];
                }
            }

            return matrix;
        }

        private static int[] ReadFromConsole()
        {
            var input = Console.ReadLine()
                .Split(new[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            return input;
        }
    }
}