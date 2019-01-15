using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Trainer
{
    public string Name { get; set; }
    public int Badges { get; set; }
    public List<Pokemon> Pokemons { get; set; }

    public Trainer(string name, Pokemon pokemon)
    {
        Name = name;

        Pokemons = new List<Pokemon>();
        Pokemons.Add(pokemon);

        Badges = 0;
    }

    public void ClearPokemons()
    {
        Pokemons = Pokemons.Where(p => p.Health > 0).ToList();
    }
}
