using System;
using System.Linq;

namespace _01.Dangerous_Floor
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] board = CreateMatrix();

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                var type = command[0];
                var startRow = int.Parse(command[1].ToString());
                var startCol = int.Parse(command[2].ToString());
                var endRow = int.Parse(command[4].ToString());
                var endCol = int.Parse(command[5].ToString());

                if (board[startRow, startCol] == type)
                {
                    bool isValidMove = CheckMove(type, startRow, startCol, endRow, endCol);

                    if (isValidMove)
                    {
                        bool isInBoard = CheckIsInBoard(board, endRow, endCol);

                        if (isInBoard)
                        {
                            board[endRow, endCol] = type;
                            board[startRow, startCol] = 'x';
                        }
                        else
                            Console.WriteLine("Move go out of board!");
                    }
                    else
                        Console.WriteLine("Invalid move!");
                }
                else
                    Console.WriteLine("There is no such a piece!");
            }
        }

        private static bool CheckIsInBoard(char[,] board, int endRow, int endCol)
        {
            if (endRow < 0 || endRow >= board.GetLength(0))
                return false;
            else if (endCol < 0 || endCol >= board.GetLength(1))
                return false;
            else
                return true;
        }

        private static bool CheckMove(char type, int startRow, int startCol, int endRow, int endCol)
        {
            switch (type)
            {
                case 'K':
                    if (Math.Abs(startRow - endRow) > 1)
                        return false;
                    else if (Math.Abs(startCol - endCol) > 1)
                        return false;
                    break;

                case 'R':
                    if (startRow != endRow && startCol != endCol)
                        return false;
                    break;

                case 'B':
                    var difference = Math.Abs(startRow - endRow);
                    if (Math.Abs(startCol - endCol) != difference)
                        return false;
                    break;

                case 'Q':
                    difference = Math.Abs(startRow - endRow);
                    if (startRow == endRow || startCol == endCol)
                        return true;
                    else if (Math.Abs(startCol - endCol) == difference)
                        return true;
                    else
                        return false;

                case 'P':
                    if (startRow - endRow == 1 && startCol == endCol)
                        return true;
                    else
                        return false;
            }

            return true;
        }

        private static char[,] CreateMatrix()
        {
            char[,] board = new char[8, 8];

            for (int row = 0; row < 8; row++)
            {
                var currentRow = Console.ReadLine().Split(',').Select(char.Parse).ToArray();
                for (int col = 0; col < 8; col++)
                {
                    board[row, col] = currentRow[col];
                }
            }

            return board;
        }
    }
}