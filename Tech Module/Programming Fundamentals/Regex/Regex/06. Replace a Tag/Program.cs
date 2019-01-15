using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _06.Replace_a_Tag
{
    class Program
    {
        static void Main(string[] args)
        {

            for (;;)
            {
                var command = Console.ReadLine();
                if (command == "end") break;

                var regex = @"<a href=(.*?)>(.*?)<\/a>";
                var replacement = @"[URL href=$1]$2[/URL]";

                var replaced = Regex.Replace(command, regex, replacement);
                Console.WriteLine(replaced);
            }
        }
    }
}
