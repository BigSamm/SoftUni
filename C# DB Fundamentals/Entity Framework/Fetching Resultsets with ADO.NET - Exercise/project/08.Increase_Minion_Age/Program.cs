using _02.Villain_Names;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace _08.Increase_Minion_Age
{
    class Program
    {
        static void Main()
        {
            IEnumerable<int> minionsIds = Console.ReadLine().Split().Select(int.Parse);

            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                UpdateMinions(minionsIds, connection);

                PrintAllMinions(minionsIds, connection);

                connection.Close();
            }
        }

        private static void PrintAllMinions(IEnumerable<int> minionsIds, SqlConnection connection)
        {
            string minionsInfo = @"select Name, Age from Minions";
            using (var command = new SqlCommand(minionsInfo, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine(reader[0] + " " + reader[1]);
                    }
                }
            }
        }

        private static void UpdateMinions(IEnumerable<int> minionsIds, SqlConnection connection)
        {
            string increaseMinionsAge = $@"update Minions set Age += 1 where id in ({String.Join(", ", minionsIds)})";
            using (var command = new SqlCommand(increaseMinionsAge, connection))
            {
                command.ExecuteNonQuery();
            }

            string updateMinionsName = $@"update Minions set Name = upper(SUBSTRING(Name, 1, 1)) + 
                    lower(substring(Name, 2, len(Name) - 1)) where id in ({String.Join(", ", minionsIds)})";
            using (var command = new SqlCommand(updateMinionsName, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
