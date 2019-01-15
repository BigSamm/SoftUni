using _02.Villain_Names;
using System;
using System.Data.SqlClient;

namespace _04.Add_Minion
{
    class Program
    {
        static void Main()
        {
            string[] minionArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string minionName = minionArgs[1];
            int minionAge = int.Parse(minionArgs[2]);
            string townName = minionArgs[3];

            string villainName = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)[1];

            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                InsertInDbIfNotExists(connection, minionName, minionAge, townName, villainName);

                connection.Close();
            }
        }

        private static void InsertInDbIfNotExists(SqlConnection connection, string minionName, int minionAge, string townName, string villainName)
        {
            int townId = InsertTownIfNotExists(connection, townName);

            int minionId = InsertMinionIfNotExists(connection, minionName, minionAge, townId);

            int villainId = InsertVillainIfNotExists(connection, villainName);

            SetMinionToVillain(connection, minionId, minionName, villainId, villainName);
        }

        private static void SetMinionToVillain(SqlConnection connection, int minionId, string minionName, int villainId, string villainName)
        {
            string minionsVillainsInfo = $@"select * from MinionsVillains where MinionId = {minionId} and VillainId = {villainId}";

            using (var command = new SqlCommand(minionsVillainsInfo, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        reader.Close();

                        string insertMinionAndVillain = $@"insert into MinionsVillains values ({minionId}, {villainId})";
                        InsertIntoDb(connection, insertMinionAndVillain);

                        Console.WriteLine($"Successfully added {minionName} to be minion of {villainName}.");
                    }
                    else
                    {
                        Console.WriteLine($"{minionName} is already minion of {villainName}.");
                    }
                }
            }
        }

        private static int InsertVillainIfNotExists(SqlConnection connection, string villainName)
        {
            int villainId = 0;
            string villainInfo = $@"select * from Villains where Name = '{villainName}'";

            using (var command = new SqlCommand(villainInfo, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        reader.Close();

                        int evilnessFactorId = 4;
                        string insertVillain = $@"insert into Villains values ('{villainName}', {evilnessFactorId})";
                        InsertIntoDb(connection, insertVillain);

                        Console.WriteLine($"Villain {villainName} was added to the database.");

                        villainId = InsertVillainIfNotExists(connection, villainName);
                    }
                    else
                    {
                        villainId = (int)reader[0];
                    }
                }
            }

            return villainId;
        }

        private static int InsertMinionIfNotExists(SqlConnection connection, string minionName, int minionAge, int townId)
        {
            int minionId = 0;
            string minionInfo = $@"select * from Minions where Name = '{minionName}'";

            using (var command = new SqlCommand(minionInfo, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        reader.Close();

                        string insertMinion = $@"insert into Minions values ('{minionName}', {minionAge}, {townId})";
                        InsertIntoDb(connection, insertMinion);

                        Console.WriteLine($"Minion {minionName} was added to the database.");

                        minionId = InsertMinionIfNotExists(connection, minionName, minionAge, townId);
                    }
                    else
                    {
                        minionId = (int)reader[0];
                    }
                }
            }

            return minionId;
        }

        private static int InsertTownIfNotExists(SqlConnection connection, string townName)
        {
            int townId = 0;
            string townInfo = $@"select * from Towns where Name = '{townName}'";

            using (var command = new SqlCommand(townInfo, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        reader.Close();

                        int countryCode = 1;
                        string insertTown = $@"insert into Towns values ('{townName}', {countryCode})";
                        InsertIntoDb(connection, insertTown);

                        Console.WriteLine($"Town {townName} was added to the database.");

                        townId = InsertTownIfNotExists(connection, townName);
                    }
                    else
                    {
                        townId = (int)reader[0];
                    }
                }
            }

            return townId;
        }

        private static void InsertIntoDb(SqlConnection connection, string cmdText)
        {
            using (var command = new SqlCommand(cmdText, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}