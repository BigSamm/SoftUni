public class Emerald : Gem
{
    private const int STRENGTH_BONUS = 1;
    private const int AGILITY_BONUS = 4;
    private const int VITALITY_BONUS = 9;

    public Emerald(ClarityLevel clarityLevel)
        : base(STRENGTH_BONUS, AGILITY_BONUS, VITALITY_BONUS, clarityLevel)
    {
    }
}