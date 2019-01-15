using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().ToList();
            var random = new Random();
            for (int pos1 = 0; pos1 < input.Count; pos1++)
            {
                var pos2 = random.Next(input.Count - 1);
                var old = input[pos1];
                input[pos1] = input[pos2];
                input[pos2] = old;

            }
            Console.WriteLine(string.Join("\r\n", input));


        }
    }
}
