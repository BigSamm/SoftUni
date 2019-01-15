using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNums = int.Parse(Console.ReadLine());
            var secondNums = int.Parse(Console.ReadLine());
            var thirdNums = int.Parse(Console.ReadLine());
            var fourthNums = int.Parse(Console.ReadLine());

            Console.WriteLine("{0:d4} {1:d4} {2:d4} {3:d4}", firstNums, secondNums, thirdNums, fourthNums);
        }
    }
}
