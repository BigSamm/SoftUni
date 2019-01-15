using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
                var num1 = int.Parse(Console.ReadLine());
                var num2 = int.Parse(Console.ReadLine());
                var symb = char.Parse(Console.ReadLine());

                if (symb == '+')
                {
                    Console.Write("{0} + {1} = {2}", num1, num2, num1 + num2);
                    if ((num1 + num2) % 2 == 0) Console.WriteLine(" - even");
                    else Console.WriteLine(" - odd");
                }
                else if (symb == '-')
                {
                    Console.Write("{0} - {1} = {2}", num1, num2, num1 - num2);
                    if ((num1 - num2) % 2 == 0) Console.WriteLine(" - even");
                    else Console.WriteLine(" - odd");
                }
                else if (symb == '*')
                {
                    Console.Write("{0} * {1} = {2}", num1, num2, num1 * num2);
                    if ((num1 * num2) % 2 == 0) Console.WriteLine(" - even");
                    else Console.WriteLine(" - odd");
                }
                else if (symb == '/')
                {
                    if (num2 == 0) Console.WriteLine("Cannot divide {0} by zero", num1);
                    else
                    {
                        Console.WriteLine("{0} / {1} = {2:f2}", num1, num2, Math.Round((double)num1/num2 , 2) );
                    }
                }
                else if (symb == '%')
                {
                    if (num2 == 0) Console.WriteLine("Cannot divide {0} by zero", num1);
                    else
                    {
                        Console.WriteLine("{0} % {1} = {2}", num1, num2, num1 % num2);
                    }
                }




            
        }
    }
}
