using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            long sum = 0L;

            while(pokemons.Count > 0)
            {
                var index = int.Parse(Console.ReadLine());

                int removedElement;
                if(index < 0)
                {
                    removedElement = pokemons[0];
                    pokemons[0] = pokemons[pokemons.Count - 1];
                }
                else if(index >= pokemons.Count)
                {
                    removedElement = pokemons[pokemons.Count - 1];
                    pokemons[pokemons.Count - 1] = pokemons[0];
                }
                else
                {
                    removedElement = pokemons[index];
                    pokemons.RemoveAt(index);
                }

                sum += removedElement;

                for (int i = 0; i < pokemons.Count; i++)
                {
                    if (pokemons[i] <= removedElement)
                        pokemons[i] += removedElement;
                    else
                        pokemons[i] -= removedElement;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
