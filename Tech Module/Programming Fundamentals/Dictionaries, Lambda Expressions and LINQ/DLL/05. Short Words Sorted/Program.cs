using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Short_Words_Sorted
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower()
                .Split('.', ',', ':', ';', '(', ')', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ')
                .ToList();

            var result = words.Where(x => x.Length < 5).Where(x => x != "").OrderBy(x => x).Distinct().ToList();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
