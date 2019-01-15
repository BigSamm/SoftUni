using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string classForInvestigate, params string[] fieldsForInvestigate)
    {
        var classType = Type.GetType(classForInvestigate);
        var classFields = classType.GetFields(
            BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
        var result = new StringBuilder();

        var classInstance = Activator.CreateInstance(classType, new object[] { });

        result.AppendLine($"Class under investigation: {classForInvestigate}");

        var neededFields = classFields.Where(f => fieldsForInvestigate.Contains(f.Name));
        foreach (var field in neededFields)
        {
            result.AppendLine(field.Name + " = " + field.GetValue(classInstance));
        }

        return result.ToString().TrimEnd();
    }
}