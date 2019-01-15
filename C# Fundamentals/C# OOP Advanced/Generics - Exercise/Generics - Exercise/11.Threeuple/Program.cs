using System;

namespace _11.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var firstName = firstLine[0];
            var lastName = firstLine[1];
            var address = firstLine[2];
            var town = firstLine[3];
            var fullName = firstName + " " + lastName;
            var threeuple1 = new Threeuple<string, string, string>(fullName, address, town);
            Console.WriteLine(threeuple1);

            var secondLine = Console.ReadLine().Split();
            var name = secondLine[0];
            var litersOfBeer = int.Parse(secondLine[1]);
            var drunkOrNor = secondLine[2] == "drunk" ? true : false;
            var threeuple2 = new Threeuple<string, int, bool>(name, litersOfBeer, drunkOrNor);
            Console.WriteLine(threeuple2);

            var thirdLine = Console.ReadLine().Split();
            name = thirdLine[0];
            var accountBalance = double.Parse(thirdLine[1]);
            var bankName = thirdLine[2];
            var threeuple3 = new Threeuple<string, double, string>(name, accountBalance, bankName);
            Console.WriteLine(threeuple3);
        }
    }
}
