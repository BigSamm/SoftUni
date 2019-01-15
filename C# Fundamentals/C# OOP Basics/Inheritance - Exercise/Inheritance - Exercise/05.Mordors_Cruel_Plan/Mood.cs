using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Mood : MoodFactory
{
    public Mood(int happinessPoints)
    {
        HappinessPoints = happinessPoints;
        Status = CalculateMood(happinessPoints);
    }

    private string CalculateMood(int happinessPoints)
    {
        if (happinessPoints < -5)
            return "Angry";
        else if (happinessPoints <= 0)
            return "Sad";
        else if (happinessPoints <= 15)
            return "Happy";
        else return "JavaScript";
    }
}
