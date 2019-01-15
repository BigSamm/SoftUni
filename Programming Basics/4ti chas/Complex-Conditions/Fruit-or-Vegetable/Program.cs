using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_or_Vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Console.ReadLine().ToLower();
            var fr = (a == "banana" || a == "apple" || a == "kiwi" || a == "cherry" || a == "lemon" || a == "grapes");
            var veg = (a == "tomato" || a == "cucumber" || a == "pepper" || a == "carrot");
            if (fr)
                Console.WriteLine("fruit");
            else if (veg)
                Console.WriteLine("vegetable");
            else Console.WriteLine("unknown");
        }
    }
}
