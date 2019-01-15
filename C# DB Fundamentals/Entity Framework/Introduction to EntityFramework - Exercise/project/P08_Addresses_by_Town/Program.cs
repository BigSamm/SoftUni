using Microsoft.EntityFrameworkCore;
using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P08_Addresses_by_Town
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            var addresses = context.Addresses
                .Include(a => a.Employees)
                .Include(a => a.Town)
                .Select(a => new
                {
                    addressText = a.AddressText,
                    townName = a.Town.Name,
                    employeesCount = a.Employees.Count
                })
                .OrderByDescending(a => a.employeesCount)
                .ThenBy(a => a.townName)
                .ThenBy(a => a.townName)
                .Take(10);

            foreach (var address in addresses)
            {
                Console.WriteLine($"{address.addressText}, {address.townName} - {address.employeesCount} employees");
            }
        }
    }
}
