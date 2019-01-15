using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _3._Word_Count
{
    class Program
    {
        static void Main()
        {
            string[] words = File.ReadAllText(@"..\..\..\words.txt").Split();
            var wordsCounter = new Dictionary<string, int>();

            foreach (var word in words)
            {
                wordsCounter[word.ToLower()] = 0;
            }

            string[] inputWords = File.ReadAllText(@"..\..\..\Input.txt")
                .Split(new char[] { ' ', ',', '.', '!', '?', '\r', '\n', '-' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in inputWords)
            {
                if (wordsCounter.ContainsKey(word.ToLower()))
                    wordsCounter[word.ToLower()]++;
            }

            var orderedWords = wordsCounter.OrderBy(w => -w.Value);
            string[] result = orderedWords.Select(w => w.Key + " - " + w.Value).ToArray();

            File.WriteAllLines(@"..\..\..\Output.txt", result);
        }
    }
}
