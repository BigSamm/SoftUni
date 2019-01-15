using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var br = 0;

            for (int i = 0; i < 99999999; i++)
            {
                people -= capacity;
                br++;
                if (people <= 0)
                    break;
            }

            Console.WriteLine(br);

        }
    }
}
