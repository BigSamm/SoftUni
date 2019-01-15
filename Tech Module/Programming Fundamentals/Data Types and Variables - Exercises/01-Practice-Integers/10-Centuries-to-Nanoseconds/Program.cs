using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = sbyte.Parse(Console.ReadLine());
            short years = (short)(centuries * 100);
            int days = (int)(years * 365.2422);
            uint hours = (uint)(days * 24);
            long mins = (long)(hours * 60);
            ulong sec = (ulong)(mins * 60);
            decimal milisec =  (decimal)(sec * 1000);
            decimal microsec = (milisec * 1000);
            decimal nanosec = (microsec * 1000);

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {mins} minutes = {sec} seconds = " +
                $"{milisec} milliseconds = {microsec} microseconds = {nanosec} nanoseconds");
        }
    }
}
