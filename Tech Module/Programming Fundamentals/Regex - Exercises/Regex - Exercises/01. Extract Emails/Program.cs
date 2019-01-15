using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _01.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"(?<=\s)[a-z\d]+([\.\-_][a-z\d]+)*@([a-z]+([-][a-z]+)*)(\.[a-z]+)+";
            var input = Console.ReadLine();
            MatchCollection validEmails = Regex.Matches(input, regex);
            foreach (Match e in validEmails)
            {
                Console.WriteLine(e);
            }
        }
    }
}
