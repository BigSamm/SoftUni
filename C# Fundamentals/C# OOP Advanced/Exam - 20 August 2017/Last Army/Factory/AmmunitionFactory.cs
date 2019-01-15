using System;
using System.Linq;
using System.Reflection;

public class AmmunitionFactory : IAmmunitionFactory
{
    public IAmmunition CreateAmmunition(string name)
    {
        Assembly assembly = Assembly.GetCallingAssembly();
        Type ammunitionType = assembly.GetTypes().FirstOrDefault(t => t.Name == name);

        if (ammunitionType == null)
            throw new ArgumentException(Constants.InvalidAmmunitionType);

        if (!typeof(IAmmunition).IsAssignableFrom(ammunitionType))
            throw new InvalidOperationException(String.Format(Constants.NotAAmmunition, name));

        object[] args = new object[] { name };
        IAmmunition ammunition = (IAmmunition)Activator.CreateInstance(ammunitionType, args);

        return ammunition;
    }

    //public IAmmunition CreateAmmunitions(string name, int number)
    //{

    //}
}