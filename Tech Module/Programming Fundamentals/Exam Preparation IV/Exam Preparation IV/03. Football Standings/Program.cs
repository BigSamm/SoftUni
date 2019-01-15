using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Football_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            var regex = $@"{key}(.+?){key}";

            for (;;)
            {
                var input = Console.ReadLine();
                if (input == "final") break;


            }
        }
    }
}
