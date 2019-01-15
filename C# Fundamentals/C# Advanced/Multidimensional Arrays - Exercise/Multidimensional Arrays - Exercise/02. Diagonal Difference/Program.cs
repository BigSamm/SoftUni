using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = createMatrix();
            
            var primaryDiagonalSum = 0;
            var secondaryDiagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int column = 0; column < matrix.GetLength(1); column++)
                {
                    if (row == column)
                    {
                        primaryDiagonalSum += matrix[row, column];
                    }
                    if (row + column == matrix.GetLength(0) - 1)
                    {
                        secondaryDiagonalSum += matrix[row, column];
                    }
                }
            }

            Console.WriteLine(Math.Abs(primaryDiagonalSum - secondaryDiagonalSum));
        }

        private static int[,] createMatrix()
        {
            var colsAndRows = int.Parse(Console.ReadLine());

            int[,] matrix = new int[colsAndRows, colsAndRows];

            for (int row = 0; row < colsAndRows; row++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int column = 0; column < inputLine.Length; column++)
                {
                    matrix[row, column] = inputLine[column];
                }
            }

            return matrix;
        }
    }
}