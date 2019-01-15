using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = sbyte.Parse(Console.ReadLine());
            var sum = 0;
            var count = 0;

            for (sbyte i = 0; i < n; i++)
            {
                var liters = short.Parse(Console.ReadLine());
                sum += liters;
                if(sum > 255)
                {
                    count++;
                    sum -= liters;
                }
            }

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            Console.WriteLine(sum);

        }
    }
}
