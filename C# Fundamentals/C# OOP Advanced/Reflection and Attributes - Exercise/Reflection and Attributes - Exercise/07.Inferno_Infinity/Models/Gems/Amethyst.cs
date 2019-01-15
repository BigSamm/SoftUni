public class Amethyst : Gem
{
    private const int STRENGTH_BONUS = 2;
    private const int AGILITY_BONUS = 8;
    private const int VITALITY_BONUS = 4;

    public Amethyst(ClarityLevel clarityLevel)
        : base(STRENGTH_BONUS, AGILITY_BONUS, VITALITY_BONUS, clarityLevel)
    {
    }
}