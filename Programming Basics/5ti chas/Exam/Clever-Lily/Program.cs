using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            var years = int.Parse(Console.ReadLine());
            var price = double.Parse(Console.ReadLine());
            var priceToy = int.Parse(Console.ReadLine());
            var toy = 0;
            var money = 10.0;
            var allMoney = 0.0;
            var vzetiPari = 0.0;

            for (int i = 1; i <= years; i++)
            {
                if (i % 2 == 1) toy++;
                else if (i % 2 == 0)
                {
                    allMoney += money;
                    money += 10;
                    vzetiPari++;                                       
                }
            }
            allMoney = allMoney + toy * priceToy - vzetiPari;

            if (allMoney >= price)
                Console.WriteLine("Yes! {0:f2}", allMoney - price);
            else if (allMoney < price)
                Console.WriteLine("No! {0:f2}", price - allMoney);
        }
    }
}
