public class Easy : Mission
{
    private const double EnduranceRequired = 20;

    public Easy(double scoreToComplete) 
        : base(Constants.EasyMissionName, EnduranceRequired, scoreToComplete)
    {
    }
}