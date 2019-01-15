using System;
using System.Linq;

namespace _05.Rubiks_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = createMatrix();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var rowOrCol = int.Parse(inputLine[0]);
                var command = inputLine[1];
                var moves = int.Parse(inputLine[2]);

                if (command == "up")
                {
                    DoUpCommand(rowOrCol, moves, matrix);
                }
                else if (command == "down")
                {
                    DoDownCommand(rowOrCol, moves, matrix);
                }
                else if (command == "right")
                {
                    DoRightCommand(rowOrCol, moves, matrix);
                }
                else if (command == "left")
                {
                    DoLeftCommand(rowOrCol, moves, matrix);
                }
            }

            var num = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] != num)
                    {
                        for (int i = row; i < matrix.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrix.GetLength(1); j++)
                            {
                                if (matrix[i, j] == num)
                                {
                                    Console.WriteLine($"Swap ({row}, {col}) with ({i}, {j})");

                                    var oldValue = matrix[row, col];
                                    matrix[row, col] = matrix[i, j];
                                    matrix[i, j] = oldValue;
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                    num++;
                }
            }
        }

        private static void DoLeftCommand(int row, int moves, int[,] matrix)
        {
            for (int i = 0; i < moves; i++)
            {
                var firstElement = matrix[row, 0];
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    matrix[row, col] = matrix[row, col + 1];
                }
                matrix[row, matrix.GetLength(1) - 1] = firstElement;
            }
        }

        private static void DoRightCommand(int row, int moves, int[,] matrix)
        {
            for (int i = 0; i < moves; i++)
            {
                var lastElement = matrix[row, matrix.GetLength(1) - 1];
                for (int col = matrix.GetLength(1) - 1; col > 0; col--)
                {
                    matrix[row, col] = matrix[row, col - 1];
                }
                matrix[row, 0] = lastElement;
            }
        }

        private static void DoDownCommand(int col, int moves, int[,] matrix)
        {
            for (int i = 0; i < moves; i++)
            {
                var lastElement = matrix[matrix.GetLength(0) - 1, col];
                for (int row = matrix.GetLength(0) - 1; row > 0; row--)
                {
                    matrix[row, col] = matrix[row - 1, col];
                }
                matrix[0, col] = lastElement;
            }
        }

        private static void DoUpCommand(int col, int moves, int[,] matrix)
        {
            for (int i = 0; i < moves; i++)
            {
                var firstElement = matrix[0, col];
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    matrix[row, col] = matrix[row + 1, col];
                }
                matrix[matrix.GetLength(0) - 1, col] = firstElement;
            }
        }

        private static int[,] createMatrix()
        {
            var rowsAndCols = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];

            int[,] matrix = new int[rows, cols];
            var num = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = num;
                    num++;
                }
            }

            return matrix;
        }
    }
}