public abstract class Gem : IGem
{
    protected Gem(int strengthBonus, int agilityBonus, int vitalityBonus, ClarityLevel clarityLevel)
    {
        this.StrengthBonus = strengthBonus;
        this.AgilityBonus = agilityBonus;
        this.VitalityBonus = vitalityBonus;
        this.ClarityLevel = clarityLevel;
    }

    public int StrengthBonus { get; private set; }

    public int AgilityBonus { get; private set; }

    public int VitalityBonus { get; private set; }

    public ClarityLevel ClarityLevel { get; private set; }
}