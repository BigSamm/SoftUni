using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = int.Parse(Console.ReadLine());
            var poor = 0;
            var good = 0;
            var verygood = 0;
            var excellent = 0;
            var allgrades = 0.0;

            for (int i = 0; i < students; i++)
            {
                var grade = double.Parse(Console.ReadLine());

                allgrades += grade;
                if (grade >= 2.0 && grade <= 2.99) poor++;
                else if (grade >= 3.0 && grade <= 3.99) good++;
                else if (grade >= 4.0 && grade <= 5.99) verygood++;
                else if (grade >= 5.0 && grade <= 6.0) excellent++;

            }

            Console.WriteLine(excellent);
            Console.WriteLine(verygood);
            Console.WriteLine(good);
            Console.WriteLine(poor);

            //Console.WriteLine("Top students: {0:f2}%", excellent / students * 100);
            //Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", verygood / students * 100);
            //Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", good / students * 100);
            //Console.WriteLine("Fail: {0:f2}%", poor / students * 100);
            //Console.WriteLine("Average: {0:f2}", allgrades / students);

        }
    }
}
