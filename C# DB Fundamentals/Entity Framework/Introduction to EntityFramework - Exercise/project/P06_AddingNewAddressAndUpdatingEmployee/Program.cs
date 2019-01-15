using P02_DatabaseFirst.Data;
using P02_DatabaseFirst.Data.Models;
using System;
using System.Linq;

namespace P06_AddingNewAddressAndUpdatingEmployee
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            var adress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            Employee employee = context.Employees.FirstOrDefault(е => е.LastName == "Nakov");
            employee.Address = adress;

            context.SaveChanges();

            var employees = context.Employees
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => e.Address.AddressText);

            Console.WriteLine(String.Join(Environment.NewLine, employees));
        }
    }
}
