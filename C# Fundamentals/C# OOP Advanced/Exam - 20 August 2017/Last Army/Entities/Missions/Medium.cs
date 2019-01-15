public class Medium : Mission
{
    private const double EnduranceRequired = 50;

    public Medium(double scoreToComplete)
        : base(Constants.MediumMissionName, EnduranceRequired, scoreToComplete)
    {
    }
}