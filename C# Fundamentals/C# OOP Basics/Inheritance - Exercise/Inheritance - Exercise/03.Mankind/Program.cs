using System;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            var studentList = Console.ReadLine().Split();
            var studentFirstName = studentList[0];
            var studentLastName = studentList[1];
            var studentFacultyNumber = studentList[2];

            var student = new Student(studentFirstName, studentLastName, studentFacultyNumber);

            var workerList = Console.ReadLine().Split();
            var workerFirstName = workerList[0];
            var workerLastName = workerList[1];
            var workerSalary = decimal.Parse(workerList[2]);
            var workerWorkHoursPerDay = double.Parse(workerList[3]);

            var worker = new Worker(workerFirstName, workerLastName, workerSalary, workerWorkHoursPerDay);

            Console.WriteLine(student);
            Console.WriteLine(worker);
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
