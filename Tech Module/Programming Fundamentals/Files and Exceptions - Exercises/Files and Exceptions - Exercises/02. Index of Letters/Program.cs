using System;
using System.Collections.Generic;

namespace _02._Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            var lettersIndex = new Dictionary<char, int>();

            string input = Console.ReadLine();
            for (int index = 0; index < input.Length; index++)
            {
                char letter = input[index];
                lettersIndex[letter] = Array.IndexOf(alphabet, letter);
            }

            foreach (var letter in lettersIndex)
            {
                Console.WriteLine(letter.Key + " -> " + letter.Value);
            }
        }
    }
}
