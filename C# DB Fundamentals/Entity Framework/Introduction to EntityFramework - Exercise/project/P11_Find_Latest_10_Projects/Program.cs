using P02_DatabaseFirst.Data;
using System;
using System.Globalization;
using System.Linq;

namespace P11_Find_Latest_10_Projects
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            var projects = context.Projects
                .OrderByDescending(p => p.StartDate)
                .Take(10)
                .OrderBy(p => p.Name);

            foreach (var p in projects)
            {
                Console.WriteLine(p.Name);
                Console.WriteLine(p.Description);
                Console.WriteLine(p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
            }
        }
    }
}
