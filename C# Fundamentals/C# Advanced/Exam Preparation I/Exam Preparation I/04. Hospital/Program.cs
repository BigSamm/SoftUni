using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Generic;

namespace _04.Hospital
{
    class Program
    {
        public static Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
        public static Dictionary<string, List<string>> departments = new Dictionary<string, List<string>>();

        static void Main(string[] args)
        {
            string inputLine;
            while ((inputLine = Console.ReadLine()) != "Output")
            {
                AddPatients(inputLine);
            }

            inputLine = "";
            while ((inputLine = Console.ReadLine()) != "End")
            {
                PrintPatients(inputLine);
            }
        }

        private static void PrintPatients(string inputLine)
        {
            if (departments.ContainsKey(inputLine))
            {
                var currentDepartment = inputLine;
                PrintDepartment(currentDepartment);
            }
            else if (doctors.ContainsKey(inputLine))
            {
                var currentDoctor = inputLine;
                PrintDoctor(currentDoctor);
            }
            else
            {
                var inputLineList = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var currentDepartment = inputLineList[0];
                var room = int.Parse(inputLineList[1]);
                PrintDepartmentRoom(currentDepartment, room);
            }
        }

        private static void PrintDepartmentRoom(string currentDepartment, int room)
        {
            var patientsInCurrentRoom = new List<string>();
            var startIndex = (room - 1) * 3;
            var endIndex = startIndex + 3;
            for (int i = startIndex; i < endIndex; i++)
            {
                patientsInCurrentRoom.Add(departments[currentDepartment][i]);
            }

            patientsInCurrentRoom = patientsInCurrentRoom.OrderBy(p => p).ToList();
            foreach (var patient in patientsInCurrentRoom)
            {
                Console.WriteLine(patient);
            }
        }

        private static void PrintDoctor(string currentDoctor)
        {
            doctors[currentDoctor] = doctors[currentDoctor].OrderBy(p => p).ToList();
            foreach (var patient in doctors[currentDoctor])
            {
                Console.WriteLine(patient);
            }
        }

        private static void PrintDepartment(string currentDepartment)
        {
            foreach (var patient in departments[currentDepartment])
            {
                Console.WriteLine(patient);
            }
        }

        private static void AddPatients(string inputLine)
        {
            var inputLineList = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            var currentDepartment = inputLineList[0];
            var currentDoctor = inputLineList[1] + " " + inputLineList[2];
            var currentPatient = inputLineList[3];

            if (doctors.ContainsKey(currentDoctor))
            {
                doctors[currentDoctor].Add(currentPatient);
            }
            else
            {
                doctors[currentDoctor] = new List<string>();
                doctors[currentDoctor].Add(currentPatient);
            }

            if (departments.ContainsKey(currentDepartment))
            {
                if (departments[currentDepartment].Count < 60)
                    departments[currentDepartment].Add(currentPatient);
            }
            else
            {
                departments[currentDepartment] = new List<string>(60);
                departments[currentDepartment].Add(currentPatient);
            }
        }
    }
}