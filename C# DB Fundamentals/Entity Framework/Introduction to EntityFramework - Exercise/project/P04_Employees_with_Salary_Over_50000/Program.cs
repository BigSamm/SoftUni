using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P04_Employees_with_Salary_Over_50000
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            var employees = context.Employees
                .Where(e => e.Salary > 50_000)
                .Select(e => e.FirstName)
                .OrderBy(e => e);

            Console.WriteLine(String.Join(Environment.NewLine, employees));
        }
    }
}
