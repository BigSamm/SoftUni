using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _04.Punctuation_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"..\..\..\sample_text.txt";
            string text = File.ReadAllText(filePath);

            char[] punctuationMarks = ".,!?:".ToCharArray();

            IEnumerable<char> result = text.Where(ch => !punctuationMarks.Contains(ch));
            Console.WriteLine(String.Join("", result));
        }
    }
}