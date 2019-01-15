using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_Grades
{
    class Program
    {
        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade { get { return Grades.Average(); } }
        }

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var allStudents = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToList();
                var gr = new List<double>();

                for (int h = 1; h < input.Count; h++)
                {
                    gr.Add(double.Parse(input[h]));
                }
                Student currentStudent = new Student
                {
                    Name = input[0],
                    Grades = gr
                };
                allStudents.Add(currentStudent);
            }
            allStudents = allStudents.OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade).ToList();
            foreach (var s in allStudents)
            {
                if(s.AverageGrade >= 5.00)
                    Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}");
            }
        }
    }
}
