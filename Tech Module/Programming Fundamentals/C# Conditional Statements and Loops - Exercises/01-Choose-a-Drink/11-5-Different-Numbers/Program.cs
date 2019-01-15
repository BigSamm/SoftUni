using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine()); 
            var y = int.Parse(Console.ReadLine());
            
            if (y - x >= 5)
            {
                for (int a = x; a <= y; a++)
                {
                    for (int b = x; b <= y; b++)
                    {
                        for (int c = x; c <= y; c++)
                        {
                            for (int d = x; d <= y; d++)
                            {
                                for (int e = x; e <= y; e++)
                                {
                                    if(x<=a && a<b && b<c && c<d && d<e && e<=y)
                                    Console.WriteLine($"{a} {b} {c} {d} {e}");
                                }
                            }

                        }
                    }
                }
            }
            else Console.WriteLine("No");



        }
    }
}
