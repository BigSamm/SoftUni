using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Flower_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var magnoliiBr = int.Parse(Console.ReadLine());
            var zumbuliBr = int.Parse(Console.ReadLine());
            var roziBr = int.Parse(Console.ReadLine());
            var kaktusiBr = int.Parse(Console.ReadLine());
            var giftPrice = double.Parse(Console.ReadLine());

            var allMoney = (magnoliiBr * 3.25) + (zumbuliBr * 4) + (kaktusiBr * 8) + (roziBr * 3.5);
            allMoney -= .05 * allMoney;

            if (allMoney >= giftPrice) Console.WriteLine("She is left with {0} leva.", Math.Floor(allMoney - giftPrice));
            else Console.WriteLine("She will have to borrow {0} leva.", Math.Ceiling(giftPrice - allMoney));


        }
    }
}
