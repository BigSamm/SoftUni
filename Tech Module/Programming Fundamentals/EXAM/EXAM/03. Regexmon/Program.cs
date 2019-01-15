using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var didimonRegex = @"[^A-Za-z\-]+";
            var bojomonRegex = @"[A-Za-z]+-[A-Za-z]+";


            var didimonCount = 0;
            var bojomonCount = 0;
            while (true)
            {
                if (didimonCount == bojomonCount)
                {
                    var didimonMatch = Regex.Match(input, didimonRegex);
                    if (didimonMatch.Success)
                    {
                        didimonCount++;
                        Console.WriteLine(didimonMatch);
                    }
                    else break;

                    var nextInput = input
                    .Skip(didimonMatch.Index + didimonMatch.Length)
                    .Take(input.Length - didimonMatch.Index + didimonMatch.Length)
                    .ToList();
                    input = String.Join("", nextInput);
                }

                else if (didimonCount > bojomonCount)
                {
                    var bojomonMatch = Regex.Match(input, bojomonRegex);
                    if (bojomonMatch.Success)
                    {
                        bojomonCount++;
                        Console.WriteLine(bojomonMatch);
                    }
                    else break;

                    var nextInput = input
                    .Skip(bojomonMatch.Index + bojomonMatch.Length)
                    .Take(input.Length - bojomonMatch.Index + bojomonMatch.Length)
                    .ToList();
                    input = String.Join("", nextInput);
                }
            }
        }
    }
}
