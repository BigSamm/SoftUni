using _02.Villain_Names;
using System;
using System.Data;
using System.Data.SqlClient;

namespace _09.Increase_Age_Stored_Procedure
{
    class Program
    {
        static void Main()
        {
            int minionId = int.Parse(Console.ReadLine());

            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                ExecuteProcedure(minionId, connection);

                PrintMinion(minionId, connection);

                connection.Close();
            }
        }

        private static void PrintMinion(int minionId, SqlConnection connection)
        {
            string minionInfo = $@"select Name, Age from Minions where id = {minionId}";
            using (var command = new SqlCommand(minionInfo, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    reader.Read();

                    Console.WriteLine($"{reader[0]} – {reader[1]} years old");
                }
            }
        }

        private static void ExecuteProcedure(int minionId, SqlConnection connection)
        {
            string procName = "dbo.usp_GetOlder";
            using (var command = new SqlCommand(procName, connection))
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@minionId", minionId);

                command.ExecuteNonQuery();
            }
        }
    }
}
