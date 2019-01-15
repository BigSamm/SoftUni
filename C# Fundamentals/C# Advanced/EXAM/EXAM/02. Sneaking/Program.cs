using System;
using System.Collections.Generic;

namespace _02.Sneaking
{
    class Program
    {
        static void Main(string[] args)
        {
            char[][] board = CreateBoard();
            var commands = Console.ReadLine().ToCharArray();

            for (int turn = 0; turn < commands.Length; turn++)
            {
                CheckForLoseOrWin(board);

                MakeCurrentTurn(board, commands[turn]);

                CheckForLoseOrWin(board);
            }
        }

        private static void MakeCurrentTurn(char[][] board, char command)
        {
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] == 'b' || board[row][col] == 'd')
                    {
                        char enemy = board[row][col];
                        MakeCurrentEnemyMove(row, col, board, enemy);
                        break;
                    }
                }
            }

            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] == 'S')
                    {
                        MakeSamTurn(command, row, col, board);
                        return;
                    }
                }
            }
        }

        private static void CheckForLoseOrWin(char[][] board)
        {
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    if (board[row][col] == 'S')
                    {
                        for (int checkCol = 0; checkCol < board[row].Length; checkCol++)
                        {
                            if (board[row][checkCol] == 'N')
                                Win(board, row, checkCol);
                            else if (board[row][checkCol] == 'b' && checkCol < col)
                                Lose(board, row, col);
                            else if (board[row][checkCol] == 'd' && checkCol > col)
                                Lose(board, row, col);
                        }
                    }
                }
            }
        }

        private static void MakeSamTurn(char command, int sRow, int sCol, char[][] board)
        {
            switch (command)
            {
                case 'U':
                    board[sRow][sCol] = '.';
                    board[sRow - 1][sCol] = 'S';
                    sRow--;
                    break;
                case 'D':
                    board[sRow][sCol] = '.';
                    board[sRow + 1][sCol] = 'S';
                    sRow++;
                    break;
                case 'L':
                    board[sRow][sCol] = '.';
                    board[sRow][sCol - 1] = 'S';
                    break;
                case 'R':
                    board[sRow][sCol] = '.';
                    board[sRow][sCol + 1] = 'S';
                    break;
                default:
                    break;
            }
        }

        private static void MakeCurrentEnemyMove(int row, int col, char[][] board, char enemy)
        {
            if (enemy == 'b')
            {
                if (col != board[row].Length - 1)
                {
                    board[row][col] = '.';
                    board[row][col + 1] = 'b';
                }
                else
                {
                    board[row][col] = 'd';
                }
            }
            else if (enemy == 'd')
            {
                if (col != 0)
                {
                    board[row][col] = '.';
                    board[row][col - 1] = 'd';
                }
                else
                {
                    board[row][col] = 'b';
                }
            }
        }

        private static void PrintBoard(char[][] board)
        {
            for (int row = 0; row < board.Length; row++)
            {
                for (int col = 0; col < board[row].Length; col++)
                {
                    Console.Write(board[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static void Lose(char[][] board, int row, int col)
        {
            board[row][col] = 'X';
            Console.WriteLine($"Sam died at {row}, {col}");
            PrintBoard(board);
            Environment.Exit(0);
        }

        private static void Win(char[][] board, int row, int col)
        {
            Console.WriteLine("Nikoladze killed!");
            board[row][col] = 'X';
            PrintBoard(board);
            Environment.Exit(0);
        }

        private static char[][] CreateBoard()
        {
            var rows = int.Parse(Console.ReadLine());

            var board = new char[rows][];

            for (int row = 0; row < rows; row++)
            {
                var inputLine = Console.ReadLine().ToCharArray();
                board[row] = inputLine;
            }

            return board;
        }
    }
}