using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    class Program
    {
        static void Main(string[] args)
        {
            var needHours = int.Parse(Console.ReadLine());
            var days = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var workHours1 = (days - (days * 0.1)) * 8;
            var workHours2 = workers * 2 * days;
            var allHours = Math.Floor(workHours1 + workHours2);
            if(allHours >= needHours) Console.WriteLine("Yes!{0} hours left.", allHours - needHours);
            else Console.WriteLine("Not enough time!{0} hours needed." , needHours - allHours);


        }
    }
}
