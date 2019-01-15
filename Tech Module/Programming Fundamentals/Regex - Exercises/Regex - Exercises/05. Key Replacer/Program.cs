using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions;

namespace _05.Key_Replacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputKey = Console.ReadLine()
                .Split(new[] { '|', '<', '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            var start = inputKey[0];
            var end = inputKey[inputKey.Count - 1];

            var regex = $@"{start}(.*?){end}";
            var inputString = Console.ReadLine();
            var matchesList = Regex.Matches(inputString, regex);

            var result = "";
            foreach (Match m in matchesList)
            {
                result += m.Groups[1].Value;
            }

            if(result != "")
                Console.WriteLine(String.Join("", result));
            else
                Console.WriteLine("Empty result");
        }
    }
}
