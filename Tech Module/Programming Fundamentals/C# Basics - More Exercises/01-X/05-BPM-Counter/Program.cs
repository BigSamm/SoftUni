using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            //var BPM = int.Parse(Console.ReadLine());
            //var beats = int.Parse(Console.ReadLine());

            //var bars = Math.Round(beats / 4.0, 1);
            //var sec = Math.Truncate(beats * 60.0 / BPM);

            //var mins = (int) sec / 60;
            //sec -= mins * 60;

            //Console.WriteLine($"{bars} bars - {mins}m {sec}s");

            long n = 2;
            for (int i = 0; i < 64; i++)
            {
                n *= n;
            }
            Console.WriteLine(n);
        }
    }
}
