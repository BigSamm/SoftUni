using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_by_Word_Casing
{
    class Program
    {
        static void Main(string[] args)
        {
            var allWords = Console.ReadLine().Split(',', ';', ':', '.', '!', '(', ')', '\"', '\'', '\\', '/', '[', ']', ' ').ToList();
            List<string> lowerCaseWords = new List<string>();
            List<string> upperCaseWords = new List<string>();
            List<string> mixedCaseWords = new List<string>();

            for (int i = 0; i < allWords.Count; i++)
            {
                char[] wordToArr = allWords[i].ToCharArray();
                bool isLowerCase = IsLowerCase(wordToArr);
                bool isUpperCase = IsUpperCase(wordToArr);
                if (isLowerCase)
                    lowerCaseWords.Add(string.Join("", wordToArr));
                else if(isUpperCase)
                    upperCaseWords.Add(string.Join("", wordToArr));
                else
                    mixedCaseWords.Add(string.Join("", wordToArr));
            }

            lowerCaseWords.RemoveAll(x => x == "");

            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCaseWords)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCaseWords)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCaseWords)}");
        }

        static bool IsUpperCase(char[] wordToArr)
        {
            for (int i = 0; i < wordToArr.Length; i++)
            {
                if ((int)wordToArr[i] < 65 || (int)wordToArr[i] > 90)
                    return false;
            }
            return true;
        }

        static bool IsLowerCase(char[] wordToArr)
        {
            for (int i = 0; i < wordToArr.Length; i++)
            {
                if ((int)wordToArr[i] < 97 || (int)wordToArr[i] > 122)
                    return false;
            }
            return true;
        }



    }
}
