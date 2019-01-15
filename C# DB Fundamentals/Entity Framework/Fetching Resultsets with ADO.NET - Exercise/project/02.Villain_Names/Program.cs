using System;
using System.Data.SqlClient;

namespace _02.Villain_Names
{
    class Program
    {
        static void Main()
        {
            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string viliansInfo = @"SELECT v.[Name], COUNT(mv.MinionId) AS [MinionsCount] FROM MinionsVillains AS mv JOIN Villains AS v 
                    ON v.Id = mv.VillainId GROUP BY v.[Name] HAVING COUNT(mv.MinionId) >= 3 ORDER BY [MinionsCount] DESC";

                using (var command = new SqlCommand(viliansInfo, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0] + " - " + reader[1]);
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}
