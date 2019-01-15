using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();


            Func<List<int>, List<int>> Add = n => n.Select(x => x + 1).ToList();
            Func<List<int>, List<int>> Multiply = n => n.Select(x => x * 2).ToList();
            Func<List<int>, List<int>> subtract = n => n.Select(x => x - 1).ToList();
            Action<List<int>> Print = n => Console.WriteLine(String.Join(" ", n));

              string command;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add": nums = Add(nums); break;
                    case "multiply": nums = Multiply(nums); break;
                    case "subtract": nums = subtract(nums); break;
                    case "print": Print(nums); break;
                }
            }
        }
    }
}