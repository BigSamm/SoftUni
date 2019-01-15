using System;
using System.Linq;
using System.Reflection;

public class WeaponFactory
{
    public IWeapon CreateWeapon(string type, string rarityLevelString, string name)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var model = assembly.GetTypes().FirstOrDefault(t => t.Name == type);

        if (model == null)
            throw new ArgumentException("Invalid Weapon Type!");

        if (!typeof(IWeapon).IsAssignableFrom(model))
            throw new ArgumentException($"{type} Is Not a Weapon Type!");

        var rarityLevel = Enum.Parse<RarityLevel>(rarityLevelString);

        var weapon = (IWeapon)Activator.CreateInstance(model, new object[] { name, rarityLevel });
        return weapon;
    }
}