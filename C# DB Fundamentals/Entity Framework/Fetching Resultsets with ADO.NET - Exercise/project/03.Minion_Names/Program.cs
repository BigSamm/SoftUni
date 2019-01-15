using _02.Villain_Names;
using System;
using System.Data.SqlClient;

namespace _3.Minion_Names
{
    class Program
    {
        static void Main()
        {
            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                int villainId = int.Parse(Console.ReadLine());
                string villainInfo = $@"SELECT v.[Name], m.[Name], m.Age FROM Villains AS v LEFT JOIN MinionsVillains AS mv 
                    ON mv.VillainId = v.Id LEFT JOIN Minions AS m ON m.Id = mv.MinionId WHERE v.Id = {villainId} ORDER BY m.[Name]";

                using (var command = new SqlCommand(villainInfo, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            if (reader.IsDBNull(1))
                            {
                                Console.WriteLine($"Villain: {reader[0]}");
                                Console.WriteLine("(no minions)");
                            }
                            else
                            {
                                Console.WriteLine($"Villain: {reader[0]}");
                                Console.WriteLine($"1. {reader[1]} {reader[2]}");

                                int counter = 2;

                                while (reader.Read())
                                {
                                    Console.WriteLine($"{counter}. {reader[1]} {reader[2]}");

                                    counter++;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine($"No villain with ID {villainId} exists in the database.");
                        }
                    }
                }

                connection.Close();
            }
        }
    }
}