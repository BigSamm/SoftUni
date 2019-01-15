using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Trainlands
{
    class Program
    {
        class Train
        {
            public string Name { get; set; }
            public Dictionary<string, string> WagonsAndPowers { get; set; }
            public long TotalPower { get; set; }
        }

        static void Main(string[] args)
        {
            var allTrains = new List<Train>();
            var createRegex = @"^([^ \-:>=]*) -> ([^ \-:>=]*) : ([^ \-:>=]*)$";
            var addRegex = @"^([^ \-:>=]*) -> ([^ \-:>=]*)$";
            var copyRegex = @"^([^ \-:>=]*) = ([^ \-:>=]*)$";

            for (;;)
            {
                var input = Console.ReadLine();
                if (input == "It's Training Men!") break;

                Match match;
                match = Regex.Match(input, createRegex);
                if (match.Success)
                    DoCreateCommand(match, allTrains, createRegex);
                else
                {
                    match = Regex.Match(input, addRegex);
                    if (match.Success)
                        DoAddCommand(match, allTrains, addRegex);
                    else
                    {
                        match = Regex.Match(input, copyRegex);
                        if (match.Success)
                            DoCopyCommand(match, allTrains, copyRegex);
                    }
                }
            }

            foreach (var train in allTrains)
            {
                train.TotalPower = 0;
                foreach (var wagon in train.WagonsAndPowers)
                {
                    train.TotalPower += int.Parse(wagon.Value);
                }
            }

            foreach (var train in allTrains)
            {
                var orderedDict = train.WagonsAndPowers
                    .OrderByDescending(w => long.Parse(w.Value))
                    .ToDictionary(k => k.Key, v => v.Value);
                train.WagonsAndPowers = orderedDict;
            }

            var result = allTrains.OrderByDescending(t => t.TotalPower).ThenBy(t => t.WagonsAndPowers.Count);

            foreach (var train in result)
            {
                Console.WriteLine($"Train: {train.Name}");
                foreach (var wagon in train.WagonsAndPowers)
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }

        private static void DoCopyCommand(Match match, List<Train> allTrains, string copyRegex)
        {
            var matches = Regex.Match(match.ToString(), copyRegex);
            var trainName = matches.Groups[1].Value;
            var otherTrainName = matches.Groups[2].Value;

            var isContains = false;
            foreach (var train in allTrains)
            {
                if (train.Name == trainName)
                {
                    foreach (var otherTrain in allTrains)
                    {
                        if (otherTrain.Name == otherTrainName)
                        {
                            foreach (var wagon in otherTrain.WagonsAndPowers)
                            {
                                train.WagonsAndPowers = otherTrain.WagonsAndPowers;
                            }
                        }
                    }
                    isContains = true;
                }
            }

            if (!isContains)
            {
                Train train = new Train();
                train.Name = trainName;
                foreach (var otherTrain in allTrains)
                {
                    if (otherTrain.Name == otherTrainName)
                    {
                        train.WagonsAndPowers = otherTrain.WagonsAndPowers;
                    }
                }
                allTrains.Add(train);
            }
        }

        private static void DoAddCommand(Match match, List<Train> allTrains, string addRegex)
        {
            var matches = Regex.Match(match.ToString(), addRegex);
            var trainName = matches.Groups[1].Value;
            var otherTrainName = matches.Groups[2].Value;

            var isContains = false;
            foreach (var train in allTrains)
            {
                if (train.Name == trainName)
                {
                    foreach (var otherTrain in allTrains)
                    {
                        if (otherTrain.Name == otherTrainName)
                        {
                            foreach (var wagon in otherTrain.WagonsAndPowers)
                            {
                                train.WagonsAndPowers[wagon.Key] = wagon.Value;
                            }
                        }
                    }
                    isContains = true;
                }
            }

            if (!isContains)
            {
                Train train = new Train();
                train.Name = trainName;
                foreach (var otherTrain in allTrains)
                {
                    if (otherTrain.Name == otherTrainName)
                    {
                        train.WagonsAndPowers = otherTrain.WagonsAndPowers;
                    }
                }
                allTrains.Add(train);
            }

            foreach (var train in allTrains)
            {
                if (train.Name == otherTrainName)
                {
                    allTrains.Remove(train);
                    break;
                }
            }
        }

        private static void DoCreateCommand(Match match, List<Train> allTrains, string createRegex)
        {
            var matches = Regex.Match(match.ToString(), createRegex);
            var trainName = matches.Groups[1].Value;
            var wagonName = matches.Groups[2].Value;
            var power = matches.Groups[3].Value;

            var isContains = false;
            foreach (var train in allTrains)
            {
                if (train.Name == trainName)
                {
                    train.WagonsAndPowers.Add(wagonName, power);
                    isContains = true;
                }
            }

            if (!isContains)
            {
                Train train = new Train();
                train.Name = trainName;
                var wagonsAndPowers = new Dictionary<string, string>();
                wagonsAndPowers[wagonName] = power;
                train.WagonsAndPowers = wagonsAndPowers;
                allTrains.Add(train);
            }
        }
    }
}
