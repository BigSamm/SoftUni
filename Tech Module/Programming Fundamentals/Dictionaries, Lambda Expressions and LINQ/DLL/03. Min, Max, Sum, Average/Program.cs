using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var listOfNums = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                listOfNums.Add(num);
            }
            Console.WriteLine("Sum = " + listOfNums.Sum());
            Console.WriteLine("Min = " + listOfNums.Min());
            Console.WriteLine("Max = " + listOfNums.Max());
            Console.WriteLine("Average = " + listOfNums.Average());
        }
    }
}
