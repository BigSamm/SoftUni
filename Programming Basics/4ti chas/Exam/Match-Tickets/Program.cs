using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var br = int.Parse(Console.ReadLine());
            var result = 0.0;

            if (br >= 1 && br <= 4) money = money * .25;
            else if (br >= 5 && br <= 9) money = money * .4;
            else if (br >= 10 && br <= 24) money = money * .5;
            else if (br >= 25 && br <= 49) money = money * .6;
            else if (br >= 50) money = money * 0.75;
            
            if (type == "Normal") result = br * 249.99;
            else if (type == "VIP") result = br * 499.99;

            if (money >= result)
                Console.WriteLine("Yes! You have {0:f2} leva left.", Math.Round(money - result, 2));
            else if (money < result)
                Console.WriteLine("Not enough money! You need {0:f2} leva.", Math.Round(result - money, 2));


        }
    }
}
