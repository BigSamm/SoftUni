using System;
using System.Linq;

namespace _01.Matrix_of_Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var columns = input[0];
            var rows = input[1];

            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string[,] matrix = new string[columns, rows];

            for (int column = 0; column < matrix.GetLength(0); column++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    var charArr = new char[] { alphabet[column], alphabet[row + column], alphabet[column] };
                    matrix[column, row] = String.Join("", charArr);   
                }
            }

            for (int column = 0; column < matrix.GetLength(0); column++)
            {
                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    Console.Write(matrix[column, row] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}