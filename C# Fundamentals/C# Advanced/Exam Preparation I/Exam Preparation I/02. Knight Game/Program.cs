using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            char[,] matrix = CreateMatrix();

            var knights = TakeKnightsIndexes(matrix);

            CheckKnightsIndexes(knights);

            var removeCounter = 0;
            Remove:
            string mostAttackedKnight = "";
            var mostAttacks = 0;
            foreach (var knight in knights)
            {
                if (knight.Value.Count > mostAttacks)
                {
                    mostAttackedKnight = knight.Key;
                    mostAttacks = knight.Value.Count;
                }
            }

            if (mostAttacks != 0)
            {
                RemoveAndReductionKnights(knights, mostAttackedKnight);
                removeCounter++;
                goto Remove;
            }
            else
            {
                Console.WriteLine(removeCounter);
                Environment.Exit(0);
            }
        }

        private static void RemoveAndReductionKnights(Dictionary<string, List<string>> knights, string mostAttackedKnight)
        {
            var knightsForReduction = knights[mostAttackedKnight];
            knights.Remove(mostAttackedKnight);

            foreach (var knight in knightsForReduction)
            {
                knights[knight].Remove(mostAttackedKnight);
            }
        }

        private static void CheckKnightsIndexes(Dictionary<string, List<string>> knights)
        {
            foreach (var knight in knights)
            {
                var knightIndexes = knight.Key.Split().Select(int.Parse).ToList();
                var row = knightIndexes[0];
                var col = knightIndexes[1];
                foreach (var knightForCheck in knights)
                {
                    var knightIndexesForCheck = knightForCheck.Key.Split().Select(int.Parse).ToList();
                    var rowForCheck = knightIndexesForCheck[0];
                    var colForCheck = knightIndexesForCheck[1];

                    if ( (Math.Abs(row - rowForCheck) == 2 && Math.Abs(col - colForCheck) == 1) ||
                         (Math.Abs(row - rowForCheck) == 1 && Math.Abs(col - colForCheck) == 2) )
                    {
                        knight.Value.Add(rowForCheck + " " + colForCheck);
                    }
                }
            }
        }

        private static Dictionary<string, List<string>> TakeKnightsIndexes(char[,] matrix)
        {
            var knights = new Dictionary<string, List<string>>();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if(matrix[row, col] == 'K')
                    {
                        knights.Add(row + " " + col, new List<string>());
                    }
                }
            }

            return knights;
        }

        private static char[,] CreateMatrix()
        {
            var n = int.Parse(Console.ReadLine());
            var matrix = new char[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var inputLine = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = inputLine[col];
                }
            }

            return matrix;
        }
    }
}