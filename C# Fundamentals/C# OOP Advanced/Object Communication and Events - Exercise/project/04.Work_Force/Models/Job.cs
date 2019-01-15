public class Job : IJob
{
    public Job(string name, IEmployee employee, int hoursOfWorkRequired)
    {
        this.Name = name;
        this.Employee = employee;
        this.HoursOfWorkRequired = hoursOfWorkRequired;
    }

    public string Name { get; private set; }

    public IEmployee Employee { get; private set; }

    public int HoursOfWorkRequired { get; private set; }

    public void Update()
    {
        this.HoursOfWorkRequired -= this.Employee.WorkHoursPerWeek;
    }
}