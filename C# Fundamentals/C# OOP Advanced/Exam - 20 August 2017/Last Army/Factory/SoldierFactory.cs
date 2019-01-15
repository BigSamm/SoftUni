using System;
using System.Linq;
using System.Reflection;

public class SoldiersFactory : ISoldierFactory
{
    public ISoldier CreateSoldier(string soldierTypeName, string name, int age, double experience, double endurance)
    {
        Assembly assembly = Assembly.GetCallingAssembly();
        Type soldierType = assembly.GetTypes().FirstOrDefault(t => t.Name == soldierTypeName);

        if (soldierType == null)
            throw new ArgumentException(Constants.InvalidSoldierType);

        if (!typeof(ISoldier).IsAssignableFrom(soldierType))
            throw new InvalidOperationException(String.Format(Constants.NotASoldier, soldierTypeName));

        object[] args = new object[] { name, age, experience, endurance };
        ISoldier soldier = (ISoldier)Activator.CreateInstance(soldierType, args);

        return soldier;
    }
}