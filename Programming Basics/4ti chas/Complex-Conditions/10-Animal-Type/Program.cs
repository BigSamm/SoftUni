using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Animal_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            var animal = Console.ReadLine().ToLower();
            var a = "";
            
            switch (animal)
            {
                case "dog": a = "mammal"; break;
                case "crocodile": a = "reptile"; break;
                case "tortoise": a = "reptile"; break;
                case "snake": a = "reptile"; break;
            }
            
            if (animal == "dog" || animal == "crocodile" || animal == "tortoise" || animal == "snake")
                Console.WriteLine(a);
            else Console.WriteLine("unknown");
        }
    }
}
