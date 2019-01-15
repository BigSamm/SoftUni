using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_SoftUni_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            var brGroups = int.Parse(Console.ReadLine());
            var allStudents = 0.0;
            var car = 0.0;
            var microBus = 0.0;
            var smallBus = 0.0;
            var bigBus = 0.0;
            var train = 0.0;


            for (int i = 0; i < brGroups; i++)
            {
                var brStudents = int.Parse(Console.ReadLine());
                allStudents += brStudents;
                if (brStudents <= 5) car += brStudents;
                else if (brStudents <= 12) microBus += brStudents;
                else if (brStudents <= 25) smallBus += brStudents;
                else if (brStudents <= 40) bigBus += brStudents;
                else if (brStudents >= 41) train += brStudents;

            }

            Console.WriteLine("{0:f2}%", car / allStudents * 100.0);
            Console.WriteLine("{0:f2}%", microBus / allStudents * 100.0);
            Console.WriteLine("{0:f2}%", smallBus / allStudents * 100.0);
            Console.WriteLine("{0:f2}%", bigBus / allStudents * 100.0);
            Console.WriteLine("{0:f2}%", train / allStudents * 100.0);

        
        }
    }
}
