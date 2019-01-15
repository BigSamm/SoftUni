using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var y = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var playSofia = (48 - h) * 3.0 / 4.0;
            p = p * 2 / 3;
            var leap = (playSofia + h + p) * 0.15;
            var result = 0.0;

            switch (y)
            {
                case "normal": result = playSofia + h + p; break;
            }

            switch (y)
            {
                case "leap": result = playSofia + h + p + leap; break;
            }

            Console.WriteLine(Math.Floor(result));           
        }
    }
}
