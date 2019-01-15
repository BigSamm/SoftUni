using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Count_Working_Days
{
    class Program
    {
        static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",
                CultureInfo.InvariantCulture);

            DateTime[] holidays = new DateTime[endDate.Year - startDate.Year + 1];
            for (int i = startDate.Year; i <= endDate.Year; i++)
            {
                holidays = new DateTime[]
                {
                    new DateTime(i, 01, 01),
                    new DateTime(i, 03, 03),
                    new DateTime(i, 05, 01),
                    new DateTime(i, 05, 06),
                    new DateTime(i, 05, 24),
                    new DateTime(i, 09, 06),
                    new DateTime(i, 09, 22),
                    new DateTime(i, 11, 01),
                    new DateTime(i, 12, 24),
                    new DateTime(i, 12, 25),
                    new DateTime(i, 12, 26)
                };
            }

            var workingDaysCounter = 0;
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var isWorkingDay = true;
                for (int h = 0; h < holidays.Length; h++)
                {
                    if (i == holidays[h])
                        isWorkingDay = false;
                }
                if (i.DayOfWeek != DayOfWeek.Saturday && i.DayOfWeek != DayOfWeek.Sunday && isWorkingDay)
                    workingDaysCounter++;
            }
            Console.WriteLine(workingDaysCounter);
            
        }
    }
}
