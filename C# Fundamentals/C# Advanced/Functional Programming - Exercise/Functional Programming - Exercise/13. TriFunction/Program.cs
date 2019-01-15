using System;
using System.Collections.Generic;
using System.Linq;

namespace _13.TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            var magicNum = int.Parse(Console.ReadLine());
            var names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> isSolution = (string name, int num) => 
            {
                var sum = 0;
                for (int i = 0; i < name.Length; i++)
                {
                    sum += name[i];
                }

                if (sum > magicNum)
                    return true;

                return false;
            };

            PrintName(names, magicNum, isSolution);
        }

        private static void PrintName(List<string> names, int magicNum, Func<string, int, bool> isSolution)
        {
            var name = names.Find(n => isSolution(n, magicNum));

            Console.WriteLine(name);
        }
    }
}