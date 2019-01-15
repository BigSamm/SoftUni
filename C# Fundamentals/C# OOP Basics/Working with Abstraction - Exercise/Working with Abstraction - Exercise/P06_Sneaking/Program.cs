using System;

namespace P06_Sneaking
{
    class Sneaking
    {
        static char[][] room;

        static void Main()
        {
            room = CreateRoom();
            int[] samPosition = TakeSamPosition();
            
            var moves = Console.ReadLine().ToCharArray();
            for (int i = 0; i < moves.Length; i++)
            {
                MakeEnemiesTurn();

                int[] enemyPos = GetEnemy(samPosition);

                bool isLose = samPosition[1] < enemyPos[1] && room[enemyPos[0]][enemyPos[1]] == 'd' && enemyPos[0] == samPosition[0] ||
                              enemyPos[1] < samPosition[1] && room[enemyPos[0]][enemyPos[1]] == 'b' && enemyPos[0] == samPosition[0];
                if (isLose)
                {
                    Lose(samPosition);
                    break;
                }

                MakeSamTurn(samPosition, moves[i]);

                enemyPos = GetEnemy(samPosition);

                if (room[enemyPos[0]][enemyPos[1]] == 'N' && samPosition[0] == enemyPos[0])
                {
                    Win(enemyPos);
                    break;
                }
            }
        }

        private static void Win(int[] nikoladzePos)
        {
            room[nikoladzePos[0]][nikoladzePos[1]] = 'X';
            Console.WriteLine("Nikoladze killed!");
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static void MakeSamTurn(int[] samPosition, char command)
        {
            room[samPosition[0]][samPosition[1]] = '.';
            switch (command)
            {
                case 'U':
                    samPosition[0]--;
                    break;
                case 'D':
                    samPosition[0]++;
                    break;
                case 'L':
                    samPosition[1]--;
                    break;
                case 'R':
                    samPosition[1]++;
                    break;
                default:
                    break;
            }
            room[samPosition[0]][samPosition[1]] = 'S';
        }

        private static void Lose(int[] samPosition)
        {
            room[samPosition[0]][samPosition[1]] = 'X';
            Console.WriteLine($"Sam died at {samPosition[0]}, {samPosition[1]}");
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    Console.Write(room[row][col]);
                }
                Console.WriteLine();
            }
        }

        private static int[] GetEnemy(int[] samPosition)
        {
            int[] getEnemy = new int[2];
            for (int i = 0; i < room[samPosition[0]].Length; i++)
            {
                if (room[samPosition[0]][i] != '.' && room[samPosition[0]][i] != 'S')
                {
                    getEnemy[0] = samPosition[0];
                    getEnemy[1] = i;
                }
            }

            return getEnemy;
        }

        private static void MakeEnemiesTurn()
        {
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'b')
                    {
                        bEnemyMove(row, col);
                        break;
                    }
                    else if (room[row][col] == 'd')
                    {
                        dEnemyMove(row, col);
                        break;
                    }
                }
            }
        }

        private static void dEnemyMove(int row, int col)
        {
            if (row >= 0 && row < room.Length && col - 1 >= 0 && col - 1 < room[row].Length)
            {
                room[row][col] = '.';
                room[row][col - 1] = 'd';
            }
            else
            {
                room[row][col] = 'b';
            }
        }

        private static void bEnemyMove(int row, int col)
        {
            if (row >= 0 && row < room.Length && col + 1 >= 0 && col + 1 < room[row].Length)
            {
                room[row][col] = '.';
                room[row][col + 1] = 'b';
            }
            else
            {
                room[row][col] = 'd';
            }
        }

        private static int[] TakeSamPosition()
        {
            int[] samPosition = new int[2];
            for (int row = 0; row < room.Length; row++)
            {
                for (int col = 0; col < room[row].Length; col++)
                {
                    if (room[row][col] == 'S')
                    {
                        samPosition[0] = row;
                        samPosition[1] = col;
                    }
                }
            }

            return samPosition;
        }

        private static char[][] CreateRoom()
        {
            int n = int.Parse(Console.ReadLine());
            room = new char[n][];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().ToCharArray();
                room[row] = new char[input.Length];
                for (int col = 0; col < input.Length; col++)
                {
                    room[row][col] = input[col];
                }
            }

            return room;
        }
    }
}
