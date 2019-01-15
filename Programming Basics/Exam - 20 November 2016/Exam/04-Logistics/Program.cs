using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var loadBr = int.Parse(Console.ReadLine());
            var allWeight = 0.0;
            var money = 0.0;

            for (int i = 0; i < loadBr; i++)
            {
                var loadWeight = int.Parse(Console.ReadLine());
                allWeight += loadWeight;

                if(allWeight <= 3) money = allWeight * 200;
                else if (allWeight <= 11) money = (3 * 200) + ((allWeight - 3) * 175);
                else if (allWeight >= 12) money = (3 * 200) + ()
            }








        }
    }
}
