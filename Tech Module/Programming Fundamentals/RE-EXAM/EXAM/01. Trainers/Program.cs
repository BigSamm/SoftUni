using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = new Dictionary<string, double>();
            teams.Add("Technical", 0);
            teams.Add("Theoretical", 0);
            teams.Add("Practical", 0);
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var distanceInMiles = int.Parse(Console.ReadLine());
                var cargoInTons = double.Parse(Console.ReadLine());
                var team = Console.ReadLine();

                var cargoInKg = cargoInTons * 1000.0;
                var cashForCargo = cargoInKg * 1.5;
                var distInM = distanceInMiles * 1600.0;
                var fuel = distInM * .7;
                var cashForFuel = fuel * 2.5;

                var participantEarnedMoney = cashForCargo - cashForFuel;

                if (team == "Technical")
                    teams["Technical"] += participantEarnedMoney;
                else if (team == "Theoretical")
                    teams["Theoretical"] += participantEarnedMoney;
                else if (team == "Practical")
                    teams["Practical"] += participantEarnedMoney;
            }

            var maxEarned = double.MinValue;
            var teamName = string.Empty;
            var teamEarned = double.MinValue;
            foreach (var team in teams)
            {
                if (team.Value > maxEarned)
                {
                    maxEarned = team.Value;
                    teamName = team.Key;
                    teamEarned = team.Value;
                }
            }

            Console.WriteLine($"The {teamName} Trainers win with ${teamEarned:f3}.");
        }
    }
}
