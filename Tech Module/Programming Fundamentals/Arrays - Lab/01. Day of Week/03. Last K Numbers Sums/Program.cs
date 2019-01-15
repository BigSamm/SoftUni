using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            int[] arr = new int[n];
            int[] seq = new int[k];
            seq[0] = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int h = i - k; h <= i - 1; h++)
                {
                    seq[i] = sum(seq[h]);
                }
                Console.Write(seq + " ");
            }
            
        }

        static int sum(int n)
        {
            int sum = 0;
            sum += n;
            return sum;
        }
    }
}
