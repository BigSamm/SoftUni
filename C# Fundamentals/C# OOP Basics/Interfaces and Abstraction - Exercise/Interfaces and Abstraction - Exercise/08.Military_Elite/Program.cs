using System;
using System.Collections.Generic;

class Program
{
    public static List<ISoldier> soldiers = new List<ISoldier>();

    static void Main(string[] args)
    {
        string inputLine;
        while((inputLine = Console.ReadLine()) != "End")
        {
            var inputList = inputLine.Split();
            var type = inputList[0];
            switch (type)
            {
                case "Private": AddPrivate(inputList); break;
                case "LeutenantGeneral": AddLeutenant(inputList); break;
                case "Engineer": AddEngineer(inputList); break;
                case "Commando": AddCommando(inputList); break;
                case "Spy": AddSpy(inputList); break;
            }
        }

        foreach (var soldier in soldiers)
        {
            Console.WriteLine(soldier);
        }
    }

    private static void AddSpy(string[] inputList)
    {
        var id = inputList[1];
        var firstName = inputList[2];
        var lastName = inputList[3];
        var codeNumber = int.Parse(inputList[4]);

        ISoldier spy = new Spy(id, firstName, lastName, codeNumber);
        soldiers.Add(spy);
    }

    private static void AddCommando(string[] inputList)
    {
        var corps = inputList[5];
        if (corps != "Airforces" && corps != "Marines")
            return;

        var id = inputList[1];
        var firstName = inputList[2];
        var lastName = inputList[3];
        var salary = decimal.Parse(inputList[4]);

        var missions = new List<Mission>();
        for (int i = 6; i < inputList.Length; i += 2)
        {
            var missionCodeName = inputList[i];
            var missionState = inputList[i + 1];
            if (missionState == "inProgress" || missionState == "Finished")
            {
                var mission = new Mission(missionCodeName, missionState);
                missions.Add(mission);
            }
        }

        ISoldier commando = new Commando(id, firstName, lastName, salary, corps, missions);
        soldiers.Add(commando);
    }

    private static void AddEngineer(string[] inputList)
    {
        var corps = inputList[5];
        if (corps != "Airforces" && corps != "Marines")
            return;

        var id = inputList[1];
        var firstName = inputList[2];
        var lastName = inputList[3];
        var salary = decimal.Parse(inputList[4]);

        var repairs = new List<Repair>();
        for (int i = 6; i < inputList.Length; i += 2)
        {
            var repairPart = inputList[i];
            var repairHours = int.Parse(inputList[i + 1]);
            var repair = new Repair(repairPart, repairHours);
            repairs.Add(repair);
        }

        ISoldier engineer = new Engineer(id, firstName, lastName, salary, corps, repairs);
        soldiers.Add(engineer);
    }

    private static void AddLeutenant(string[] inputList)
    {
        var id = inputList[1];
        var firstName = inputList[2];
        var lastName = inputList[3];
        var salary = decimal.Parse(inputList[4]);

        var privates = new List<Private>();
        for (int i = 5; i < inputList.Length; i++)
        {
            var privateId = inputList[i];
            var currentPrivate = soldiers.Find(p => p.Id == privateId);
            privates.Add((Private)currentPrivate);
        }

        ISoldier leutenant = new LeutenantGeneral(id, firstName, lastName, salary, privates);
        soldiers.Add(leutenant);
    }

    private static void AddPrivate(string[] inputList)
    {
        var id = inputList[1];
        var firstName = inputList[2];
        var lastName = inputList[3];
        var salary = decimal.Parse(inputList[4]);

        ISoldier privateSoldier = new Private(id, firstName, lastName, salary);
        soldiers.Add(privateSoldier);
    }
}