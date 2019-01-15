using _02.Villain_Names;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace _07.Print_All_Minion_Names
{
    class Program
    {
        static void Main()
        {
            List<string> minionsNames = GetAllMinions();

            int i = 0;
            for (int j = minionsNames.Count - 1; j >= 0; j--)
            {
                if (i == j)
                {
                    Console.WriteLine(minionsNames[i]);

                    return;
                }
                else if (j - i == 1)
                {
                    Console.WriteLine(minionsNames[i]);
                    Console.WriteLine(minionsNames[j]);

                    return;
                }

                Console.WriteLine(minionsNames[i]);
                Console.WriteLine(minionsNames[j]);

                i++;
            }
        }

        private static List<string> GetAllMinions()
        {
            var minionsNames = new List<string>();

            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string minionsInfo = @"select Name from Minions";

                using (var command = new SqlCommand(minionsInfo, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            minionsNames.Add((string)reader[0]);
                        }
                    }
                }

                connection.Close();
            }

            return minionsNames;
        }
    }
}
