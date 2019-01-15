namespace _05.Filter_By_Age
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var people = new Dictionary<string, int>(); 

            int linesCount = int.Parse(Console.ReadLine());

            for (int counter = 0; counter < linesCount; counter++)
            {
                string[] args = Console.ReadLine().Split();
                string name = args[0];
                int age = int.Parse(args[1]);

                people[name] = age;
            }


        }
    }
}