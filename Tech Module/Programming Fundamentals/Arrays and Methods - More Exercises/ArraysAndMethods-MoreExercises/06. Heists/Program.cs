using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            var expenses = 0;
            int jewelsCount = 0;
            int goldCount = 0;
            for (;;)
            {
                string[] arrs = Console.ReadLine().Split(' ').ToArray();

                if (arrs[0] == "Jail" && arrs[1] == "Time")
                {
                    break;
                }
                else
                {
                    jewelsCount += arrs[0].Where(ch => ch == '%').Count();
                    goldCount += arrs[0].Where(ch => ch == '$').Count();
                    expenses += int.Parse(arrs[1]);
                }
            }
            var money = jewelsCount * prices[0];
            money += goldCount * prices[1];

            if(money >= expenses)
                Console.WriteLine($"Heists will continue. Total earnings: {money - expenses}.");
            else
                Console.WriteLine($"Have to find another job. Lost: {expenses - money}.");
        }
    }
}
