using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Count_the_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var br = 0;
            try
            {
                for (int i = 0; i < 100; i++)
                {
                    var n = int.Parse(Console.ReadLine());
                    br++;
                }
            }
            catch
            {
                Console.WriteLine(br);
            }



        }
    }
}
