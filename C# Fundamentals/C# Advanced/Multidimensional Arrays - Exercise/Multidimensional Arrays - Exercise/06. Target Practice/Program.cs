using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Target_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = createMatrix();

            FillMatrix(matrix);

            Shooting(matrix);

            FallingDown(matrix);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static void FallingDown(char[,] matrix)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
                {
                    if(matrix[row, col] == ' ')
                    {
                        for (int i = row - 1; i >= 0; i--)
                        {
                            if(matrix[i, col] != ' ')
                            {
                                matrix[row, col] = matrix[i, col];
                                matrix[i, col] = ' ';
                                break;
                            }
                        }
                    }
                }
            }
        }

        private static void Shooting(char[,] matrix)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var shotedRow = input[0];
            var shotedCol = input[1];
            var radius = input[2];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(Math.Pow(row - shotedRow, 2) + Math.Pow(col - shotedCol, 2) <= radius * radius)
                    {
                        matrix[row, col] = ' ';
                    }
                }
            }        
        }

        private static void FillMatrix(char[,] matrix)
        {
            var input = Console.ReadLine();

            var queue = new Queue<char>();
            var matrixLength = matrix.GetLength(0) * matrix.GetLength(1);
            while(queue.Count < matrixLength)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    queue.Enqueue(input[i]);

                    if (queue.Count == matrixLength)
                        break;
                }
            }

            var forLeft = true;
            for (int row = matrix.GetLength(0) - 1; row >= 0; row--)
            {
                if (forLeft)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        matrix[row, col] = queue.Dequeue();
                    }
                    forLeft = false;
                }
                else
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = queue.Dequeue();
                    }
                    forLeft = true;
                }                
            }
        }

        private static char[,] createMatrix()
        {
            var rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];

            char[,] matrix = new char[rows, cols];

            return matrix;
        }
    }
}