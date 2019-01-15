using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var firstCount = 0;
            var secondCount = 0;

            for (int i = 0; i < n; i++)
            {
                var @string = Console.ReadLine();

                if (@string == "(")
                {
                    firstCount++;
                    if (firstCount - secondCount > 1)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (@string == ")")
                {
                    secondCount++;
                    if (firstCount - secondCount != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
            }

            if (firstCount == secondCount)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }

        }
    }
}
