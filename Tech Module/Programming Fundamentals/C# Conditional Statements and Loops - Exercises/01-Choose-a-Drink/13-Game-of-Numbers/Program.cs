using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var magicNum = int.Parse(Console.ReadLine());

            var check = false;
            var i = m;
            var h = m;
            var br = 0;
            
            for (i = m; i >= n; i--)
            {
                for (h = m; h >= n; h--)
                {
                    //Console.WriteLine(i + "  " + h);
                    br++;
                    if(i + h == magicNum)
                    {
                        check = true;
                        break;
                    }
                    if (h <= 0) break;
                }
                if (i <= 0) break;
                if (check) break;
            }

            if (check)
                Console.WriteLine($"Number found! {i} + {h} = {magicNum}");
            else
            {
                Console.WriteLine($"{br} combinations - neither equals {magicNum}");
            }

        }
    }
}
