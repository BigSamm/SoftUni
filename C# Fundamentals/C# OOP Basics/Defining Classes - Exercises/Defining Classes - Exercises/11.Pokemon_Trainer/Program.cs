using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<Trainer> trainers = GetAllTrainers();

        string element;
        while((element = Console.ReadLine()) != "End")
        {
            foreach (var trainer in trainers)
            {
                if (trainer.Pokemons.Any(p => p.Element == element))
                {
                    trainer.Badges++;
                }
                else
                {
                    trainer.Pokemons.ForEach(p => p.Health -= 10);
                    trainer.ClearPokemons();
                }
            }
        }

        trainers = trainers.OrderByDescending(t => t.Badges).ToList();
        foreach (var trainer in trainers)
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }

    private static List<Trainer> GetAllTrainers()
    {
        var trainers = new List<Trainer>();

        string command;
        while ((command = Console.ReadLine()) != "Tournament")
        {
            var commandList = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var trainerName = commandList[0];
            var pokName = commandList[1];
            var pokElement = commandList[2];
            var pokHealth = commandList[3];

            var pokemon = new Pokemon(pokName, pokElement, pokHealth);
            
            if (trainers.Any(t => t.Name == trainerName))
            {
                var trainer = trainers.Find(t => t.Name == trainerName);
                trainer.Pokemons.Add(pokemon);
            }
            else
            {
                var trainer = new Trainer(trainerName, pokemon);
                trainers.Add(trainer);
            }
        }

        return trainers;
    }
}
