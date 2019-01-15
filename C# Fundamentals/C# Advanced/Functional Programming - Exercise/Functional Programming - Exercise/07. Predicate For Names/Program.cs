using System;
using System.Linq;

namespace _07.Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());

            Predicate<string> isLessThanOrEqualN = n => n.Length <= N;

            Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(name => 
                {
                    if (isLessThanOrEqualN(name))
                        Console.WriteLine(name);
                });
        }
    }
}