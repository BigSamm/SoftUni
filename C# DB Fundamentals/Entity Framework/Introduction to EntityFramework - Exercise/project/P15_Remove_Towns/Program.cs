using P02_DatabaseFirst.Data;
using System;
using System.Linq;

namespace P15_Remove_Towns
{
    class Program
    {
        static void Main()
        {
            var context = new SoftUniContext();

            string townName = Console.ReadLine();
            var town = context.Towns.SingleOrDefault(t => t.Name == townName);
            var addresses = context.Addresses.Where(a => a.Town == town);

            foreach (var employee in context.Employees)
            {
                if (addresses.Any(a => a.AddressId == employee.AddressId))
                {
                    employee.AddressId = null;
                }
            }

            context.Addresses.RemoveRange(addresses);
            context.Towns.Remove(town);

            int addressesCount = addresses.Count();
            string address = addressesCount == 1 ? "address" : "addresses";
            Console.WriteLine($"{addressesCount} {address} in {townName} was deleted");

            context.SaveChanges();
        }
    }
}
