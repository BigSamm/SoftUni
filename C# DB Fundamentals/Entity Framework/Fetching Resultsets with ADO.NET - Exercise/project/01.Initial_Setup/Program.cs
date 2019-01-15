using System.Data.SqlClient;

namespace _01.Initial_Setup
{
    class Program
    {
        public const string CONNECTION_STRING = @"Server=DESKTOP-V2T7ERB\SQLEXPRESS;Integrated Security = True";

        static void Main()
        {
            using (var connection = new SqlConnection(CONNECTION_STRING))
            {
                connection.Open();

                string dbCreate = @"CREATE DATABASE MinionsDB";
                ExecuteNonQuery(connection, dbCreate);

                connection.ChangeDatabase("MinionsDB");

                string tableCountries = @"CREATE TABLE Countries (Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50))";
                ExecuteNonQuery(connection, tableCountries);

                string tableTowns = @"CREATE TABLE Towns(Id INT PRIMARY KEY IDENTITY,Name VARCHAR(50), 
                    CountryCode INT FOREIGN KEY REFERENCES Countries(Id))";
                ExecuteNonQuery(connection, tableTowns);

                string tableMinions = @"CREATE TABLE Minions(Id INT PRIMARY KEY IDENTITY, Name VARCHAR(30), 
                    Age INT, TownId INT FOREIGN KEY REFERENCES Towns(Id))";
                ExecuteNonQuery(connection, tableMinions);

                string tableEvilnessFactors = @"CREATE TABLE EvilnessFactors(Id INT PRIMARY KEY IDENTITY, 
                    Name VARCHAR(50))";
                ExecuteNonQuery(connection, tableEvilnessFactors);

                string tableVillains = @"CREATE TABLE Villains (Id INT PRIMARY KEY IDENTITY, Name VARCHAR(50), 
                    EvilnessFactorId INT FOREIGN KEY REFERENCES EvilnessFactors(Id))";
                ExecuteNonQuery(connection, tableVillains);

                string tableMinionsVillians = @"CREATE TABLE MinionsVillains (MinionId INT FOREIGN KEY 
                    REFERENCES Minions(Id),VillainId INT FOREIGN KEY REFERENCES Villains(Id),CONSTRAINT 
                    PK_MinionsVillains PRIMARY KEY (MinionId, VillainId))";
                ExecuteNonQuery(connection, tableMinionsVillians);

                string countriesInsert = @"INSERT INTO Countries ([Name]) VALUES ('Bulgaria'),('England'),('Cyprus'),('Germany'),('Norway')";
                ExecuteNonQuery(connection, countriesInsert);

                string townsInsert = @"INSERT INTO Towns ([Name], CountryCode) VALUES ('Plovdiv', 1),('Varna', 1),('Burgas', 1),('Sofia', 1),
                    ('London', 2),('Southampton', 2),('Bath', 2),('Liverpool', 2),('Berlin', 3),('Frankfurt', 3),('Oslo', 4)";
                ExecuteNonQuery(connection, townsInsert);

                string minionsInsert = @"INSERT INTO Minions (Name,Age, TownId) VALUES('Bob', 42, 3),('Kevin', 1, 1),('Bob ', 32, 6),
                    ('Simon', 45, 3),('Cathleen', 11, 2),('Carry ', 50, 10),('Becky', 125, 5),('Mars', 21, 1),('Misho', 5, 10),
                    ('Zoe', 125, 5),('Json', 21, 1)";
                ExecuteNonQuery(connection, minionsInsert);

                string evilnessFactorsInsert = @"INSERT INTO EvilnessFactors (Name) VALUES ('Super good'),('Good'),('Bad'),
                    ('Evil'),('Super evil')";
                ExecuteNonQuery(connection, evilnessFactorsInsert);

                string villiansInsert = @"INSERT INTO Villains (Name, EvilnessFactorId) VALUES ('Gru',2),('Victor',1),('Jilly',3),
                    ('Miro',4),('Rosen',5),('Dimityr',1),('Dobromir',2)";
                ExecuteNonQuery(connection, villiansInsert);

                string minionsVilliansInsert = @"INSERT INTO MinionsVillains (MinionId, VillainId) VALUES (4,2),(1,1),(5,7),(3,5),
                    (2,6),(11,5),(8,4),(9,7),(7,1),(1,3),(7,3),(5,3),(4,3),(1,2),(2,1),(2,7)";
                ExecuteNonQuery(connection, minionsVilliansInsert);

                connection.Close();
            }
        }

        private static void ExecuteNonQuery(SqlConnection connection, string dbCreate)
        {
            using (var command = new SqlCommand(dbCreate, connection))
            {
                command.ExecuteNonQuery();
            }
        }
    }
}
