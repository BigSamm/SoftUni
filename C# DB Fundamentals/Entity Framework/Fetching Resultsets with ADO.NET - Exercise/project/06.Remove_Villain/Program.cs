using _02.Villain_Names;
using System;
using System.Data.SqlClient;

namespace _06.Remove_Villain
{
    class Program
    {
        static void Main()
        {
            int villainId = int.Parse(Console.ReadLine());

            using (var connection = new SqlConnection(Configuration.ConnectionString))
            {
                connection.Open();

                string villainInfo = $@"select v.[Name], count(mv.MinionId) from Villains as v join MinionsVillains as mv 
                    on mv.VillainId = v.Id where v.Id = {villainId} group by v.[Name]";

                using (var command = new SqlCommand(villainInfo, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string villainName = (string)reader[0];
                            int minionsCount = (int)reader[1];

                            reader.Close();
                            DeleteVillainFromDb(villainId, connection);

                            Console.WriteLine($"{villainName} was deleted.");
                            Console.WriteLine($"{minionsCount} minions were released.");
                        }
                        else
                        {
                            Console.WriteLine("No such villain was found.");
                        }
                    }
                }

                connection.Close();
            }
        }

        private static void DeleteVillainFromDb(int villainId, SqlConnection connection)
        {
            string cascadeDelete = @"ALTER TABLE MinionsVillains ADD CONSTRAINT FK_MinionsVillains_Villains 
                FOREIGN KEY (VillainId) REFERENCES Villains(Id) ON DELETE CASCADE";
            using (var command = new SqlCommand(cascadeDelete, connection))
            {
                command.ExecuteNonQuery();
            }

            string villainDelete = $@"delete from Villains where Id = {villainId}";
            using (var command = new SqlCommand(villainDelete, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
