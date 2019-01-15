public class PartTimeEmployee : AbstractEmployee
{
    private const int WORK_HOURS_PER_WEEK = 20;

    public PartTimeEmployee(string name) 
        : base(name, WORK_HOURS_PER_WEEK)
    {
    }
}