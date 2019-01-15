public class Hard : Mission
{
    private const double EnduranceRequired = 80;

    public Hard(double scoreToComplete) 
        : base(Constants.HardMissionName, EnduranceRequired, scoreToComplete)
    {
    }
}
