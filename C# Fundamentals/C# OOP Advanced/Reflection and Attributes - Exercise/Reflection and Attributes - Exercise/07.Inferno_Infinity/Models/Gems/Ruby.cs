public class Ruby : Gem
{
    private const int STRENGTH_BONUS = 7;
    private const int AGILITY_BONUS = 2;
    private const int VITALITY_BONUS = 5;

    public Ruby(ClarityLevel clarityLevel)
        : base(STRENGTH_BONUS, AGILITY_BONUS, VITALITY_BONUS, clarityLevel)
    {
    }
}