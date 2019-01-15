using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _02.Extract_Sent.by_Keyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyWord = Console.ReadLine();
            var input = Console.ReadLine();
            var regex = $@"(^|(?<=\s))[A-Z][^.!?]*\W" + keyWord + @"\W.*?(?=[\.\?\!])";
            
            var sentences = Regex.Matches(input, regex);
            foreach (Match s in sentences)
            {
                Console.WriteLine(s);
            }
        }
    }
}
