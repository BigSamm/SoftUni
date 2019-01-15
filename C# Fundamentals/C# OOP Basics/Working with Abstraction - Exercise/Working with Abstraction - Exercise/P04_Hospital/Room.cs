using System;
using System.Collections.Generic;
using System.Text;

public class Room
{
    public List<string> Patients { get; set; }

    public Room(string patient)
    {
        Patients = new List<string>(3);
        Patients.Add(patient);
    }
}
