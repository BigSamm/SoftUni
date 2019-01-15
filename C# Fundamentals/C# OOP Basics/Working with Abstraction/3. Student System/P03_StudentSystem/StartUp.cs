using System;

class StartUp
{
    static void Main()
    {
        StudentSystem studentSystem = new StudentSystem();

        string command;
        while ((command = Console.ReadLine()) != "Exit")
        {
            ParseCommand(command, studentSystem);
        }
    }

    private static void ParseCommand(string command, StudentSystem studentSystem)
    {
        string[] args = command.Split();

        if (args[0] == "Create")
        {
            AddNewStudent(args, studentSystem);
        }
        else if (args[0] == "Show")
        {
            var name = args[1];
            if (studentSystem.Repo.ContainsKey(name))
            {
                var student = studentSystem.Repo[name];
                Console.WriteLine(student);
            }
        }
    }

    private static void AddNewStudent(string[] args, StudentSystem studentSystem)
    {
        var name = args[1];
        var age = int.Parse(args[2]);
        var grade = double.Parse(args[3]);
        if (!studentSystem.Repo.ContainsKey(name))
        {
            var student = new Student(name, age, grade);
            studentSystem.Repo[name] = student;
        }
    }
}
