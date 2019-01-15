using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _04.Pokemon_Evolution
{
    class Program
    {
        class Pokemon
        {
            public string Name { get; set; }
            public Dictionary<string, string> Evolutions { get; set; }
        }

        static void Main(string[] args)
        {
            var allPokemons = new List<Pokemon>();
            for (;;)
            {
                var input = Console.ReadLine();
                if (input == "wubbalubbadubdub") break;

                var regex = @"[^\- >]+";
                var matches = Regex.Matches(input, regex).Cast<Match>().Select(m => m.Value).ToList();

                if (matches.Count == 1)
                {
                    var name = matches[0];
                    foreach (var pok in allPokemons)
                    {
                        if(pok.Name == name)
                        {
                            Print(name, pok);
                        }
                    }
                }
                else
                {
                    var name = matches[0];
                    var type = matches[1];
                    var index = matches[2];
                    
                    if(allPokemons.Any(p => p.Name == name))
                    {
                        foreach (var pok in allPokemons)
                        {
                            if (pok.Name == name)
                            {
                                if (pok.Evolutions.ContainsKey(type))
                                    pok.Evolutions[type] += $" {index}";
                                else
                                    pok.Evolutions.Add(type, index);
                            }
                        }
                    }
                    else
                    {
                        Pokemon pokemon = new Pokemon();
                        pokemon.Name = name;
                        var evolution = new Dictionary<string, string>();
                        evolution[type] = index;
                        pokemon.Evolutions = evolution;
                        allPokemons.Add(pokemon);
                    }
                }
            }

            var result = new Dictionary<string, string>();
            foreach (var pok in allPokemons)
            {
                result = pok.Evolutions.OrderBy(p => p.Value).ToDictionary(a => a.Key, a => a.Value);
            }

            foreach (var pok in result)
            {
                Print(pok.Name, pok);
            }
        }

        //private static void OrderedPrint(string name, Pokemon pok)
        //{
        //    Console.WriteLine($"#{name}");
        //    var forPrint = pok.Evolutions.OrderByDescending(p => p.Value);
        //    foreach (var evo in pok.Evolutions)
        //    {
        //        var indexList = evo.Value.Split().Select(int.Parse).ToList();
        //        for (int i = 0; i < indexList.Count; i++)
        //        {
        //            Console.WriteLine($"{evo.Key} <-> {indexList[i]}");
        //        }
        //    }
        //}

        private static void Print(string name, Pokemon pok)
        {
            Console.WriteLine($"#{name}");
            foreach (var evo in pok.Evolutions)
            {
                var indexList = evo.Value.Split().Select(int.Parse).ToList();
                for (int i = 0; i < indexList.Count; i++)
                {
                    Console.WriteLine($"{evo.Key} <-> {indexList[i]}");
                }
            }
        }
    }
}
