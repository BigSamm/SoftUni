using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using _02.Villain_Names;

namespace _05.Change_Town_Names_Casing
{
    class Program
    {
        static void Main()
        {
            string countryName = Console.ReadLine();

            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string upperTownNames = $@"update t set t.[Name] = UPPER(t.[Name]) from Towns as t 
                    join Countries as c on c.Id = t.CountryCode where c.[Name] = '{countryName}'";

                using (var command = new SqlCommand(upperTownNames, connection))
                {
                    int rowsAffectedCount = command.ExecuteNonQuery();

                    if (rowsAffectedCount == 0)
                    {
                        Console.WriteLine("No town names were affected.");
                        connection.Close();
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine($"{rowsAffectedCount} town names were affected.");
                    }
                }

                var townNames = new List<string>();

                string townsInfo = $@"select t.[Name] from Towns as t join Countries as c on c.Id = t.CountryCode 
                    where c.[Name] = '{countryName}'";

                using (var command = new SqlCommand(townsInfo, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            townNames.Add((string)reader[0]);
                        }
                    }
                }

                Console.WriteLine("[" + String.Join(",", townNames) + "]");

                connection.Close();
            }
        }
    }
}
