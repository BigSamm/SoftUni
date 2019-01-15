using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
                var hourExam = int.Parse(Console.ReadLine());
                var minExam = int.Parse(Console.ReadLine());
                var hourStudent = int.Parse(Console.ReadLine());
                var minStudent = int.Parse(Console.ReadLine());

                var exam = hourExam * 60 + minExam;
                var student = hourStudent * 60 + minStudent;
                var Late = student - exam;
                var onTime = exam - student;

                if (Late > 0 && Late < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0} minutes after the start", Late);
                }
                else if (Late >= 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1:d2} hours after the start", Late / 60, Late % 60);
                }

                else if (onTime == 0)
                {
                    Console.WriteLine("On time");
                }
                else if (onTime <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", onTime);
                }

                else if (onTime > 30 && onTime < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", onTime);
                }
                else if (onTime >= 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:d2} hours before the start", onTime / 60, onTime % 60);
                }

        }
    }
}
