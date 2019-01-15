using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var sec1 = int.Parse(Console.ReadLine());
            var sec2 = int.Parse(Console.ReadLine());
            var sec3 = int.Parse(Console.ReadLine());
            int min = 0;

            var sec = sec1 + sec2 + sec3;
            if (sec / 60 > 0 && sec / 60 <=1) min += 1;
            else if (sec / 60 > 1) min += 2;

            sec = sec % 60;
            if (sec < 10)
                Console.WriteLine(min + ":0" + sec);
            else
                Console.WriteLine(min + ":" + sec);

        }
    }
}
