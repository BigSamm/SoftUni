using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = CreateMatrix();

            var maxSum = int.MinValue;
            var stack = new Stack<int>();

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    var currentSum = 0;
                    for (int currentRow = row; currentRow < row + 3; currentRow++)
                    {
                        for (int currentCol = col; currentCol < col + 3; currentCol++)
                        {
                            currentSum += matrix[currentRow, currentCol];
                        }
                    }

                    if(currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        for (int currentRow = row; currentRow < row + 3; currentRow++)
                        {
                            for (int currentCol = col; currentCol < col + 3; currentCol++)
                            {
                                stack.Push(matrix[currentRow, currentCol]);
                            }
                        }
                    }
                }
            }

            var result = new Stack<int>();
            for (int i = 0; i < 9; i++)
            {
                result.Push(stack.Pop());
            }

            Console.WriteLine($"Sum = {maxSum}");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(result.Pop() + " ");
                }
                Console.WriteLine();
            }
        }

        private static int[,] CreateMatrix()
        {
            var rowsAndCols = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    matrix[row, column] = inputLine[column];
                }
            }

            return matrix;
        }
    }
}