public interface IJob
{
    string Name { get; }

    IEmployee Employee { get; }

    int HoursOfWorkRequired { get; }

    void Update();
}