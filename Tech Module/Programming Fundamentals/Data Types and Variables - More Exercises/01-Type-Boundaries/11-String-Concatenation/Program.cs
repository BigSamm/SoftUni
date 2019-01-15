using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_String_Concatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            var delimiter = char.Parse(Console.ReadLine());
            var evenOrOdd = Console.ReadLine();
            var n = int.Parse(Console.ReadLine());
            var result = "";

            for (int i = 1; i <= n; i++)
            {
                var word = Console.ReadLine();
                if (evenOrOdd == "odd" && i % 2 == 1)
                    result += word + delimiter;
                else if (evenOrOdd == "even" && i % 2 == 0)
                    result += word + delimiter;
            }

            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);

        }
    }
}
