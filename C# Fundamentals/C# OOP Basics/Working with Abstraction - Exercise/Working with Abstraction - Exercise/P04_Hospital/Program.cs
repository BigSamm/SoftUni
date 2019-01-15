using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static List<Doctor> doctors = new List<Doctor>();
    public static List<Department> departments = new List<Department>();

    public static void Main()
    {
        string command;
        while ((command = Console.ReadLine()) != "Output")
        {
            ParseCommand(command);
        }

        while ((command = Console.ReadLine()) != "End")
        {
            string[] args = command.Split();

            if (args.Length == 1)
            {
                var department = departments.Find(d => d.Name == args[0]);
                Console.WriteLine(string.Join("\n", department.Patients));
            }
            else if (args.Length == 2 && int.TryParse(args[1], out int room))
            {
                var departmentRoom = departments.Find(d => d.Name == args[0]).Rooms[room - 1].Patients.OrderBy(p => p);
                Console.WriteLine(string.Join("\n", departmentRoom));
            }
            else
            {
                var doctorPatients = doctors.Find(d => d.Name == args[0] + args[1]).Patients.OrderBy(p => p);
                Console.WriteLine(string.Join("\n", doctorPatients));
            }
        }
    }

    private static void ParseCommand(string command)
    {
        string[] tokens = command.Split();

        var doctorFirstName = tokens[1];
        var doctorLastName = tokens[2];
        var doctorFullName = doctorFirstName + doctorLastName;

        var patient = tokens[3];

        ParseCurrentDoctor(doctorFullName, patient);

        var departmentName = tokens[0];
        ParseDepartment(departmentName, patient);
    }

    private static void ParseDepartment(string departmentName, string patient)
    {
        bool isDepartmentExist = departments.Any(d => d.Name == departmentName);
        if (!isDepartmentExist)
        {
            var newDepartment = new Department(departmentName, patient);
            newDepartment.AddPatientInRoom(patient);

            departments.Add(newDepartment);
            return;
        }

        bool isTherePlace = departments.FirstOrDefault(d => d.Name == departmentName).Patients.Count < 60;
        if (!isTherePlace)
            return;

        var department = departments.Find(d => d.Name == departmentName);
        department.Patients.Add(patient);

        department.AddPatientInRoom(patient);
    }

    private static void ParseCurrentDoctor(string doctorName, string patient)
    {
        if (doctors.Any(d => d.Name == doctorName))
        {
            var doctor = doctors.Find(d => d.Name == doctorName);
            doctor.Patients.Add(patient);
        }
        else
        {
            var doctor = new Doctor(doctorName, patient);
            doctors.Add(doctor);
        }
    }
}
