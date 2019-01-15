using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_DNA_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            var magicSum = int.Parse(Console.ReadLine());

            var br = 0;
            var first = 0;
            var sum = 0;

                for (char i = 'A'; i <= 'T'; i++)
                {
                    for (char h = 'A'; h <= 'T'; h++)
                    {
                        for (char g = 'A'; g <= 'T'; g++)
                        {
                            if ((i == 'A' || i == 'C' || i == 'G' || i == 'T') &&
                                (h == 'A' || h == 'C' || h == 'G' || h == 'T') &&
                                (g == 'A' || g == 'C' || g == 'G' || g == 'T'))
                            {
                                
                                if (br % 4 == 0) Console.WriteLine();
                                if (i == 'A') sum += 1;
                                else if (i == 'C') sum += 2;
                                else if (i == 'G') sum += 3;
                                else if (i == 'T') sum += 4;

                                if (h == 'A') sum += 1;
                                else if (h == 'C') sum += 2;
                                else if (h == 'G') sum += 3;
                                else if (h == 'T') sum += 4;

                                if (g == 'A') sum += 1;
                                else if (g == 'C') sum += 2;
                                else if (g == 'G') sum += 3;
                                else if (g == 'T') sum += 4;

                                if (sum < magicSum) Console.Write($"X{i}{h}{g}X ");
                                else Console.Write($"O{i}{h}{g}O ");

                                br++;
                            }
                            sum = 0;


                        }
                    }
                }

            




        }
    }
}
