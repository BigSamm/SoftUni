using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Back_to_the_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var year = int.Parse(Console.ReadLine());
            var old = 18;

            for (int i = 0; i <= year - 1800; i++)
            {
                if (i % 2 == 0) money -= 12000;
                else if (i % 2 == 1) money -= 12000 + old * 50;
                old++;
            }

            if (money >= 0) Console.WriteLine("Yes! He will live a carefree life and will have {0:f2} dollars left.", money);
            else Console.WriteLine("He will need {0:f2} dollars to survive.", Math.Abs(money));

        }
    }
}
