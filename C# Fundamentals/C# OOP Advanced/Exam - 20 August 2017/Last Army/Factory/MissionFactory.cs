using System;
using System.Linq;
using System.Reflection;

public class MissionFactory : IMissionFactory
{
    public IMission CreateMission(string difficultyLevel, double neededPoints)
    {
        Assembly assembly = Assembly.GetCallingAssembly();
        Type missionType = assembly.GetTypes().FirstOrDefault(t => t.Name == difficultyLevel);

        if (missionType == null)
            throw new ArgumentException(Constants.InvalidMissionType);

        if (!typeof(IMission).IsAssignableFrom(missionType))
            throw new InvalidOperationException(String.Format(Constants.NotAMission, difficultyLevel));

        object[] args = new object[] { neededPoints };
        IMission mission = (IMission)Activator.CreateInstance(missionType, args);

        return mission;
    }
}