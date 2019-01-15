using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Pizza_Ingredients
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients = Console.ReadLine().Split(' ').ToArray();
            var ingredientLength = int.Parse(Console.ReadLine());

            var ingredientsCount = 0;
            ingredientsCount = GetIngredientsCount(ingredients.Length, ingredients, ingredientLength, ingredientsCount);
            var x = 0;
            string[] usingIngredients = new string[ingredientsCount];

            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == ingredientLength)
                {
                    Console.WriteLine($"Adding {ingredients[i]}.");
                    usingIngredients[x] = ingredients[i];
                    x++;
                    if (x == 10)
                        break;
                }
            }
            Console.WriteLine($"Made pizza with total of {ingredientsCount} ingredients.");
            Console.WriteLine($"The ingredients are: {String.Join(", ", usingIngredients)}.");
        }

        private static int GetIngredientsCount(int length, string[] ingredients, int ingredientLength, int ingredientsCount)
        {
            for (int i = 0; i < ingredients.Length; i++)
            {
                if (ingredients[i].Length == ingredientLength)
                {
                    ingredientsCount++;
                    if (ingredientsCount == 10)
                        break;
                }
            }
            return ingredientsCount;
        }
    }
}
