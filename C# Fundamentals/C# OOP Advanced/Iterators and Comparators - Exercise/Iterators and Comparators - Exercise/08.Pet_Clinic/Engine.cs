using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Engine
{
    public void Run()
    {
        var clinics = new List<Clinic>();
        var pets = new List<Pet>();

        var lines = int.Parse(Console.ReadLine());
        for (int i = 0; i < lines; i++)
        {
            var args = Console.ReadLine().Split();
            var command = args[0];

            try
            {
                switch (command)
                {
                    case "Create":
                        var name = args[2];
                        if (args[1] == "Clinic")
                        {
                            var roomsCount = int.Parse(args[3]);
                            var newClinic = new Clinic(name, roomsCount);
                            clinics.Add(newClinic);
                        }
                        else if (args[1] == "Pet")
                        {
                            var age = int.Parse(args[3]);
                            var kind = args[4];
                            var newPet = new Pet(name, age, kind);
                            pets.Add(newPet);
                        }
                        break;
                    case "Add":
                        var pet = pets.Find(p => p.Name == args[1]);
                        var clinic = clinics.Find(cl => cl.Name == args[2]);
                        Console.WriteLine(clinic.Add(pet));
                        break;
                    case "Release":
                        clinic = clinics.Find(cl => cl.Name == args[1]);
                        Console.WriteLine(clinic.Release());
                        break;
                    case "HasEmptyRooms":
                        clinic = clinics.Find(cl => cl.Name == args[1]);
                        Console.WriteLine(clinic.HasEmptyRooms());
                        break;
                    case "Print":
                        clinic = clinics.Find(cl => cl.Name == args[1]);
                        if (args.Length == 2)
                        {
                            Console.WriteLine(clinic.Print());
                        }
                        else if (args.Length == 3)
                        {
                            var room = int.Parse(args[2]);
                            Console.WriteLine(clinic.Print(room));
                        }
                        break;
                }
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid Operation!");
            }
        }
    }
}