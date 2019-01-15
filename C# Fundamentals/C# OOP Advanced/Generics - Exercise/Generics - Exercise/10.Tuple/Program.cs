using System;

namespace _10.Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine().Split();
            var firstName = firstLine[0];
            var lastName = firstLine[1];
            var address = firstLine[2];
            var fullName = firstName + " " + lastName;
            var tuple1 = new Tuple<string, string>(fullName, address);
            Console.WriteLine(tuple1);

            var secondLine = Console.ReadLine().Split();
            var name = secondLine[0];
            var litersOfBeer = int.Parse(secondLine[1]);
            var tuple2 = new Tuple<string, int>(name, litersOfBeer);
            Console.WriteLine(tuple2);

            var thirdLine = Console.ReadLine().Split();
            var intNum = int.Parse(thirdLine[0]);
            var doubleNum = double.Parse(thirdLine[1]);
            var tuple3 = new Tuple<int, double>(intNum, doubleNum);
            Console.WriteLine(tuple3);
        }
    }
}
