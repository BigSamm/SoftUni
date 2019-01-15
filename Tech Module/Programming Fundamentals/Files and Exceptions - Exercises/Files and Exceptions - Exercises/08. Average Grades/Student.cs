using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Average_Grades
{
    public class Student
    {
        private List<double> grades;

        public Student(string name, IEnumerable<double> grades)
        {
            this.Name = name;
            this.grades = new List<double>(grades);
        }

        public string Name { get; private set; }

        public IReadOnlyCollection<double> Grades => this.grades.AsReadOnly();

        public double AverageGrade => this.grades.Average();
    }
}
