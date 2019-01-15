public interface IGem
{
    int StrengthBonus { get; }

    int AgilityBonus { get; }

    int VitalityBonus { get; }

    ClarityLevel ClarityLevel { get; }
}