public class StandardEmployee : AbstractEmployee
{
    private const int WORK_HOURS_PER_WEEK = 40;

    public StandardEmployee(string name) 
        : base(name, WORK_HOURS_PER_WEEK)
    {
    }
}