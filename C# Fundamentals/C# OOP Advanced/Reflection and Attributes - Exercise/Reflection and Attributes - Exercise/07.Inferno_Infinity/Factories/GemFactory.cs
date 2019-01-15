using System;
using System.Linq;
using System.Reflection;

public class GemFactory
{
    public IGem CreateGem(string type, string clarityLevelString)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var model = assembly.GetTypes().FirstOrDefault(t => t.Name == type);

        if (model == null)
            throw new ArgumentException("Invalid Gem Type!");

        if (!typeof(IGem).IsAssignableFrom(model))
            throw new ArgumentException($"{type} Is Not a Gem Type!");

        var clarityLevel = Enum.Parse<ClarityLevel>(clarityLevelString);

        var gem = (IGem)Activator.CreateInstance(model, new object[] { clarityLevel });
        return gem;
    }
}