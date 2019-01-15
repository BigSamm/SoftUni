using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var LS = 0;
            var RS = 0;
            for (int i = 0; i < n; i++)
            {
                var left = int.Parse(Console.ReadLine());
                LS += left;
            }
            for (int i = 0; i < n; i++)
            {
                var right = int.Parse(Console.ReadLine());
                RS += right;
            }
            if (LS == RS) Console.WriteLine("Yes, sum = " + LS);
            else Console.WriteLine("No, diff = " + Math.Abs(LS - RS));

            // 6-7 min
        }
    }
}
