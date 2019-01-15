using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            var country = Console.ReadLine();

            if (country == "England" || country == "USA")
                Console.WriteLine("English");
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
                Console.WriteLine("Spanish");
            else
                Console.WriteLine("unknown");
        }
    }
}
