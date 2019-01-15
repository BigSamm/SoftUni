using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Department
{
    public string Name { get; set; }
    public List<string> Patients { get; set; }
    public List<Room> Rooms { get; set; }

    public Department(string name, string patient)
    {
        Name = name;

        Patients = new List<string>(60);
        Patients.Add(patient);


        Rooms = new List<Room>(20);
    }

    public void AddPatientInRoom(string patient)
    {
        if (Rooms.Any(r => r.Patients.Count < 3))
        {
            var room = Rooms.Find(r => r.Patients.Count < 3);
            room.Patients.Add(patient);
        }
        else
        {
            var room = new Room(patient);
            Rooms.Add(room);
        }
    }
}
