using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b[A-Za-z][\w\d]{2,25}\b";
            var input = Console.ReadLine();
            var validUsers = Regex.Matches(input, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToList();

            var maxLength = 0;
            var resultArr = new string[2];
            for (int i = 0; i < validUsers.Count - 1; i++)
            {
                var currentLength = validUsers[i].Length + validUsers[i + 1].Length;
                if (currentLength > maxLength)
                {
                    maxLength = currentLength;
                    resultArr[0] = validUsers[i];
                    resultArr[1] = validUsers[i + 1];
                }
            }

            foreach (var u in resultArr)
            {
                Console.WriteLine(u);
            }
        }
    }
}
