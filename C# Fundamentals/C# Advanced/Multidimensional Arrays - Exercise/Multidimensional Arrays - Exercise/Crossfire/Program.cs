using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace _09.Crossfire
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArray = CreateJaggedArray();

            string inputLine;
            while((inputLine = Console.ReadLine()) != "Nuke it from orbit") 
            {
                var command = inputLine.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                RunCommand(command, jaggedArray);

                jaggedArray = MoveLeft(jaggedArray);
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                Console.WriteLine(String.Join(" ", jaggedArray[row]));
            }
        }

        private static int[][] MoveLeft(int[][] jaggedArray)
        {
            for (int row = 0; row < jaggedArray.Length; row++)
            {
                var newArr = jaggedArray[row].Where(n => n != 0).ToArray();
                jaggedArray[row] = newArr;
            }

            jaggedArray = jaggedArray.Where(row => row.Length != 0).ToArray();

            return jaggedArray;
        }

        private static void RunCommand(int[] command, int[][] jaggedArray)
        {
            var row = command[0];
            var col = command[1];
            var radius = command[2];

            if (row >= 0 && row < jaggedArray.Length && col >= 0 && col < jaggedArray[row].Length)
            {
                jaggedArray[row][col] = 0;

                Destroy(row - 1, col, Math.Min(radius, jaggedArray.Length - row), jaggedArray, "up");
                Destroy(row + 1, col, Math.Min(radius, jaggedArray.Length - row - 1), jaggedArray, "down");
                Destroy(row, col + 1, Math.Min(radius, jaggedArray[row].Length - col - 1), jaggedArray, "right");
                Destroy(row, col - 1, Math.Min(radius, jaggedArray[row].Length - col), jaggedArray, "left");
            }
            else if (row < 0)
            {
                radius += row;
                row = 0;
                Destroy(row, col, Math.Min(radius, jaggedArray.Length), jaggedArray, "down");
            }
            else if (row >= jaggedArray.Length)
            {
                radius -= row;
                row = jaggedArray.Length - 1;
                Destroy(row, col, Math.Min(radius, jaggedArray.Length), jaggedArray, "up");

            }
            else if (col < 0)
            {
                radius += col;
                col = 0;
                Destroy(row, col, Math.Min(radius, jaggedArray[row].Length), jaggedArray, "right");
            }
            else if (col >= jaggedArray[row].Length)
            {
                radius -= col;
                col = jaggedArray[row].Length - 1;
                Destroy(row, col, Math.Min(radius, jaggedArray[row].Length), jaggedArray, "left");
            }
        }

        private static void Destroy(int row, int col, int radius, int[][] jaggedArray, string direction)
        {
            for (int i = 0; i < radius; i++)
            {
                try
                {
                    jaggedArray[row][col] = 0;
                    switch (direction)
                    {
                        case "up": row--; break;
                        case "down": row++; break;
                        case "right": col++; break;
                        case "left": col--; break;
                    }
                }
                catch
                {
                    switch (direction)
                    {
                        case "up": row--; break;
                        case "down": row++; break;
                        case "right": col++; break;
                        case "left": col--; break;
                    }
                }
            }
        }

        private static int[][] CreateJaggedArray()
        {
            var rowsAndCols = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = new int[cols];
            }

            var num = 1;
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    jaggedArray[row][col] = num;
                    num++;
                }
            }

            return jaggedArray;
        }
    }
}