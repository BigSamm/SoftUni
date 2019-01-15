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

    public string AnalyzeAcessModifiers(string className)
    {
        var classType = Type.GetType(className);
        var result = new StringBuilder();

        var classFields = classType.GetFields(
            BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
        foreach (var field in classFields)
        {
            result.AppendLine(field.Name + " must be private!");
        }

        var classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var method in classPublicMethods.Where(m => m.Name.StartsWith("get")))
        {
            result.AppendLine(method.Name + " have to be public!");
        }

        var classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
        foreach (var method in classNonPublicMethods.Where(m => m.Name.StartsWith("set")))
        {
            result.AppendLine(method.Name + " have to be private!");
        }

        return result.ToString().TrimEnd();
    }

    public string RevealPrivateMethods(string className)
    {
        var classType = Type.GetType(className);

        var result = new StringBuilder();
        result.AppendLine("All Private Methods of Class: " + className);

        var baseClassName = classType.BaseType.Name;
        result.AppendLine("Base Class: " + baseClassName);

        var classNonPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
        foreach (var method in classNonPublicMethods)
        {
            result.AppendLine(method.Name);
        }

        return result.ToString().TrimEnd();
    }

    public string CollectGettersAndSetters(string className)
    {
        var classType = Type.GetType(className);
        var result = new StringBuilder();

        var classMethods = classType.GetMethods(
            BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);

        foreach (var getMethod in classMethods.Where(m => m.Name.StartsWith("get")))
        {
            result.AppendLine(getMethod.Name + " will return " + getMethod.ReturnType);
        }

        foreach (var setMethod in classMethods.Where(m => m.Name.StartsWith("set")))
        {
            var paramType = setMethod.GetParameters().First().ParameterType;
            result.AppendLine(setMethod.Name + " will set field of " + paramType);
        }

        return result.ToString().TrimEnd();
    }
}