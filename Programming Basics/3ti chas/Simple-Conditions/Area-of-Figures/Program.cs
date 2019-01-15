using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string fig = Console.ReadLine();
            var num1 = double.Parse(Console.ReadLine());
            double result = 0;
            if (fig == "square")
                result = num1 * num1;
            else if (fig == "rectangle")
            {
                var num2 = double.Parse(Console.ReadLine());
                result = num1 * num2;
            }
            else if (fig == "circle")
                result = num1 * num1 * Math.PI;
            else if (fig == "triangle")
            {
                var num2 = double.Parse(Console.ReadLine());
                result = (num1 * num2) / 2;
            }

            Console.WriteLine(Math.Round(result, 3));
        }
    }
}
