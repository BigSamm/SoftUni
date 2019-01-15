using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i= 1; i<= n; i++)
            {
                int sum = 0;
                int start = i;
                while (i> 0)
                {
                    sum += i% 10;
                    i= i/ 10;
                }
                bool check = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{start} -> {check}");
                i= start;
            }


        }
    }
}
