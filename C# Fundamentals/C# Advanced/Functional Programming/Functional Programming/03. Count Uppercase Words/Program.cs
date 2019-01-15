using System;
using System.Linq;

namespace _03.Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> checker = w => char.IsUpper(w[0]);
            Console.ReadLine()
            .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Where(checker)
            .ToList()
            .ForEach(w => Console.WriteLine(w));
        }
    }
}