using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Radioactive_Bunnies
{
    class Program
    {
        public static bool isLose = false;
        public static bool isWin = false;
        public static int pRow = 0;
        public static int pCol = 0;

        static void Main(string[] args)
        {
            char[,] lair = InitializeLair();
            var commands = Console.ReadLine();

            TakePlayerRowAndCol(lair);

            List<string> bunnies = TakeBunniesIndexes(lair);

            for (int turn = 0; turn < commands.Length; turn++)
            {
                var currentCommand = commands[turn];
                MakePlayerTurn(lair, currentCommand, bunnies);

                bunnies = MakeBunniesTurn(lair, bunnies);
                bunnies = ClearNoNeededBunnies(bunnies, lair);

                isLose = ChechForLose(bunnies);
                
                if (isWin)
                {
                    FixPlayerCoordinates(lair);

                    PrintLair(lair, bunnies);
                    Console.WriteLine($"won: {pRow} {pCol}");
                    Environment.Exit(0);
                }
                else if (isLose)
                {
                    PrintLair(lair, bunnies);
                    Console.WriteLine($"dead: {pRow} {pCol}");
                    Environment.Exit(0);
                }
            }
        }

        private static void FixPlayerCoordinates(char[,] lair)
        {
            if (pRow < 0)
                pRow++;
            else if (pRow >= lair.GetLength(0))
                pRow--;
            else if (pCol < 0)
                pCol++;
            else if (pCol >= lair.GetLength(1))
                pCol--;
        }

        private static void PrintLair(char[,] lair, List<string> bunnies)
        {
            foreach (var bunnie in bunnies)
            {
                var rowAndCol = bunnie.Split().Select(int.Parse).ToArray();
                int row = rowAndCol[0];
                int col = rowAndCol[1];

                lair[row, col] = 'B';
            }

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    Console.Write(lair[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool ChechForLose(List<string> bunnies)
        {
            string playerCell = pRow + " " + pCol;
            if (bunnies.Contains(playerCell))
                return true;

            return false;
        }

        private static List<string> ClearNoNeededBunnies(List<string> bunnies, char[,] lair)
        {
            bunnies = bunnies.Distinct().ToList();

            for (int i = 0; i < bunnies.Count; i++)
            {
                int[] rowAndCol = bunnies[i].Split().Select(int.Parse).ToArray();
                int row = rowAndCol[0];
                int col = rowAndCol[1];

                if (row < 0 || row >= lair.GetLength(0) || col < 0 || col >= lair.GetLength(1))
                {
                    bunnies.Remove(bunnies[i]);
                    i--;
                }
            }

            return bunnies;
        }

        private static List<string> MakeBunniesTurn(char[,] lair, List<string> bunnies)
        {
            var bunniesForAdd = new List<string>();

            foreach (var bunnie in bunnies)
            {
                int[] rowAndCol = bunnie.Split().Select(int.Parse).ToArray();
                var row = rowAndCol[0];
                var col = rowAndCol[1];

                bunniesForAdd.Add((row - 1) + " " + col);
                bunniesForAdd.Add((row + 1) + " " + col);
                bunniesForAdd.Add(row + " " + (col + 1));
                bunniesForAdd.Add(row + " " + (col - 1));
            }

            bunnies.AddRange(bunniesForAdd);
            return bunnies;
        }

        private static List<string> TakeBunniesIndexes(char[,] lair)
        {
            var bunniesIndexes = new List<string>();

            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == 'B')
                        bunniesIndexes.Add(row + " " + col);
                }
            }

            return bunniesIndexes;
        }

        private static void TakePlayerRowAndCol(char[,] lair)
        {
            var isPlayerFind = false;
            for (int row = 0; row < lair.GetLength(0); row++)
            {
                for (int col = 0; col < lair.GetLength(1); col++)
                {
                    if (lair[row, col] == 'P')
                    {
                        pRow = row;
                        pCol = col;

                        lair[row, col] = '.';

                        isPlayerFind = true;
                        break;
                    }
                }

                if (isPlayerFind)
                    break;
            }
        }

        private static void MakePlayerTurn(char[,] lair, char command, List<string> bunnies)
        {
            switch (command)
            {
                case 'U': CheckUpCommand(lair, command, bunnies); break;
                case 'D': CheckDownCommand(lair, command, bunnies); break;
                case 'R': CheckRightCommand(lair, command, bunnies); break;
                case 'L': CheckLeftCommand(lair, command, bunnies); break;
            }
        }

        private static void CheckLeftCommand(char[,] lair, char command, List<string> bunnies)
        {
            if (pCol == 0)
            {
                isWin = true;
            }

            pCol--;
            string targetCell = pRow + " " + pCol;
            if (bunnies.Contains(targetCell))
            {
                isLose = true;
            }
        }

        private static void CheckRightCommand(char[,] lair, char command, List<string> bunnies)
        {
            if (pCol == lair.GetLength(1) - 1)
            {
                isWin = true;
            }

            pCol++;
            string targetCell = pRow + " " + pCol;
            if (bunnies.Contains(targetCell))
            {
                isLose = true;
            }
        }

        private static void CheckDownCommand(char[,] lair, char command, List<string> bunnies)
        {
            if (pRow == lair.GetLength(0) - 1)
            {
                isWin = true;
            }

            pRow++;
            string targetCell = pRow + " " + pCol;
            if (bunnies.Contains(targetCell))
            {
                isLose = true;
            }
        }

        private static void CheckUpCommand(char[,] lair, char command, List<string> bunnies)
        {
            if (pRow == 0)
            {
                isWin = true;
            }
            
            pRow--;
            string targetCell = pRow + " " + pCol;
            if (bunnies.Contains(targetCell))
            {
                isLose = true;
            }
        }

        private static char[,] InitializeLair()
        {
            int[] rowsAndCols = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var rows = rowsAndCols[0];
            var cols = rowsAndCols[1];

            char[,] lair = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var inputLine = Console.ReadLine();
                for (int col = 0; col < cols; col++)
                {
                    lair[row, col] = inputLine[col];
                }
            }

            return lair;
        }
    }
}