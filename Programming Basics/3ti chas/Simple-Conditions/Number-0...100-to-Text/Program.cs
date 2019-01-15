using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            if (num == 11) Console.WriteLine("eleven");
            else if (num == 12) Console.WriteLine("twelve");
            else if (num == 13) Console.WriteLine("thirteen");
            else if (num == 14) Console.WriteLine("fourteen");
            else if (num == 15) Console.WriteLine("fifteen");
            else if (num == 16) Console.WriteLine("sixteen");
            else if (num == 17) Console.WriteLine("seventeen");
            else if (num == 18) Console.WriteLine("eighteen");
            else if (num == 19) Console.WriteLine("nineteen");

            if (num < 0 || num > 100) Console.WriteLine("invalid number");
            else if (num % 100 > 20 && num % 100 < 30) Console.Write("twenty ");
            else if (num % 100 > 30 && num % 100 < 40) Console.Write("thirty ");
            else if (num % 100 > 40 && num % 100 < 50) Console.Write("fourty ");
            else if (num % 100 > 50 && num % 100 < 60) Console.Write("fifty ");
            else if (num % 100 > 60 && num % 100 < 70) Console.Write("sixty ");
            else if (num % 100 > 70 && num % 100 < 80) Console.Write("seventy ");
            else if (num % 100 > 80 && num % 100 < 90) Console.Write("eighty ");
            else if (num % 100 > 90 && num % 100 < 100) Console.Write("ninety ");
            else if (num == 100) Console.WriteLine("one hundred");

            
            if (num == 20) Console.WriteLine("twenty");
            else if (num == 30) Console.WriteLine("thirty");
            else if (num == 40) Console.WriteLine("fourty");
            else if (num == 50) Console.WriteLine("fifty");
            else if (num == 60) Console.WriteLine("sixty");
            else if (num == 70) Console.WriteLine("seventy");
            else if (num == 80) Console.WriteLine("eighty");
            else if (num == 90) Console.WriteLine("ninety");


            
            if (num == 0) Console.WriteLine("zero");
            else if (num % 10 == 1 && num != 11 && num < 100) Console.WriteLine("one");
            else if (num % 10 == 2 && num != 12 && num < 100) Console.WriteLine("two");
            else if (num % 10 == 3 && num != 13 && num < 100) Console.WriteLine("three");
            else if (num % 10 == 4 && num != 14 && num < 100) Console.WriteLine("four");
            else if (num % 10 == 5 && num != 15 && num < 100) Console.WriteLine("five");
            else if (num % 10 == 6 && num != 16 && num < 100) Console.WriteLine("six");
            else if (num % 10 == 7 && num != 17 && num < 100) Console.WriteLine("seven");
            else if (num % 10 == 8 && num != 18 && num < 100) Console.WriteLine("eight");
            else if (num % 10 == 9 && num != 19 && num < 100) Console.WriteLine("nine");
            else if (num == 10) Console.WriteLine("ten");
        }
    }
}
