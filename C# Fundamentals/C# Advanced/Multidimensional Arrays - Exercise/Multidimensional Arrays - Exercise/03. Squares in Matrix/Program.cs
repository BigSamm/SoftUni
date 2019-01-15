using System;
using System.Linq;

namespace _03.Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = createMatrix();

            var counter = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if(matrix[row, col] == matrix[row, col + 1] &&
                       matrix[row, col] == matrix[row + 1, col] &&
                       matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }

        private static char[,] createMatrix()
        {
            var rowsAndCols = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
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