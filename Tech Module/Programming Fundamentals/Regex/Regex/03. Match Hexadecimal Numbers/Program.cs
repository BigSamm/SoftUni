using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Match_Hexadecimal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(0x)?[0-9A-F]+\b";
            var input = Console.ReadLine();
            var numbers = Regex.Matches(input, regex)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();
            Console.WriteLine(String.Join(" ", numbers));
        }
    }
}
