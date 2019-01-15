using System;
using System.Collections.Generic;

class StartUp
{
    static void Main()
    {
        var jobs = new List<IJob>();
        var employees = new List<IEmployee>();

        string inputLine;
        while((inputLine = Console.ReadLine()) != "End")
        {
            if (inputLine == "Pass Week")
            {
                for (int index = 0; index < jobs.Count; index++)
                {
                    var job = jobs[index];
                    job.Update();
                    if (job.HoursOfWorkRequired <= 0)
                    {
                        jobs.RemoveAt(index);
                        index--;
                        Console.WriteLine($"Job {job.Name} done!");
                    }
                }
            }
            else if (inputLine == "Status")
            {
                foreach (var job in jobs)
                {
                    Console.WriteLine($"Job: {job.Name} Hours Remaining: {job.HoursOfWorkRequired}");
                }
            }
            else
            {
                var args = inputLine.Split();
                if (args[0] == "Job")
                {
                    var jobName = args[1];
                    var hoursOfWorkRequired = int.Parse(args[2]);
                    var employeeName = args[3];
                    var employee = employees.Find(em => em.Name == employeeName);

                    var job = new Job(jobName, employee, hoursOfWorkRequired);
                    jobs.Add(job);
                }
                else if (args[0] == "StandardEmployee")
                {
                    var employeeName = args[1];
                    IEmployee employee = new StandardEmployee(employeeName);
                    employees.Add(employee);
                }
                else if (args[0] == "PartTimeEmployee")
                {
                    var employeeName = args[1];
                    IEmployee employee = new PartTimeEmployee(employeeName);
                    employees.Add(employee);
                }
            }
        }
    }
}