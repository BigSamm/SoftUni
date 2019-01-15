using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string inputLine;
        while((inputLine = Console.ReadLine()) != "End")
        {
            var inputList = inputLine.Split();
            var name = inputList[0];
            var country = inputList[1];
            var age = int.Parse(inputList[2]);

            var citizen = new Citizen(name, country, age);

            IPerson person = citizen;
            Console.WriteLine(person.GetName());

            IResident resident = citizen;
            Console.WriteLine(resident.GetName());
        }
    }
}