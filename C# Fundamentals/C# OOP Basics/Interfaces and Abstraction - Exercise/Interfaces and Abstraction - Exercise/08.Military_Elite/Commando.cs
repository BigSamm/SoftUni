using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Commando : SpecialisedSoldier, ICommando
{
    public Commando(string id, string fitstName, string lastName,
        decimal salary, string corps, List<Mission> missions)
        : base(id, fitstName, lastName, salary, corps)
    {
        this.Missions = missions;
    }

    public List<Mission> Missions { get; private set; }

    public void CompleteMission(string missionName)
    { 
        if (this.Missions.Any(m => m.CodeName == missionName))
        {
            var mission = this.Missions.Find(m => m.CodeName == missionName);
            mission.State = "Finished";
        }
    }

    public override string ToString()
    {
        var result = new StringBuilder();

        result.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {this.Salary:f2}");
        result.AppendLine($"Corps: {this.Corps}");
        result.AppendLine("Missions:");
        foreach (var mission in this.Missions)
        {
            result.AppendLine("  " + mission);
        }

        return result.ToString().Trim();
    }
}