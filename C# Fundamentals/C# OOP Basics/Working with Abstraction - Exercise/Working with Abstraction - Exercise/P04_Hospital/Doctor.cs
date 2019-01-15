using System;
using System.Collections.Generic;
using System.Text;

public class Doctor
{
    public string Name { get; set; }
    public List<string> Patients { get; set; }

    public Doctor(string name, string patient)
    {
        Name = name;

        Patients = new List<string>();
        Patients.Add(patient);
    }
}
