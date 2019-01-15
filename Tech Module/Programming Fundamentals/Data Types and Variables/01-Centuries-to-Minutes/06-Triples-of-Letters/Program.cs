using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n-1; i++)
            {
                for (int h = 0; h <= n-1; h++)
                {
                    for (int g = 0; g <= n-1; g++)
                    {
                        char firstLet = (char)('a' + i);
                        char secondLet = (char)('a' + h);
                        char thirdLet = (char)('a' + g);
                        Console.WriteLine($"{firstLet}{secondLet}{thirdLet}");
                    }
                }
            }



        }
    }
}
