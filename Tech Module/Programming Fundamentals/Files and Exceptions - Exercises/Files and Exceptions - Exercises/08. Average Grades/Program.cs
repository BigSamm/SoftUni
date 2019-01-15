using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Average_Grades
{
    class Program
    {
        static void Main()
        {
            var students = new List<Student>();

            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] args = Console.ReadLine().Split();
                string name = args[0];
                double[] grades = args.Skip(1).Select(double.Parse).ToArray();

                Student student = new Student(name, grades);
                students.Add(student);
            }

            IEnumerable<Student> result = students
                .Where(s => s.AverageGrade >= 5.00)
                .OrderBy(s => s.Name)
                .ThenBy(s => -s.AverageGrade);

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2}");
            }
        }
    }
}
