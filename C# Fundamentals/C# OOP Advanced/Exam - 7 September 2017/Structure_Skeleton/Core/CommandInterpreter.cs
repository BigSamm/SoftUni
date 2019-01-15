using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
//using Microsoft.Extensions.DependencyInjection;

public class CommandInterpreter : ICommandInterpreter
{
    //IServiceProvider serviceProvider;

    public CommandInterpreter(IProviderController providerController, IHarvesterController harvesterController)
    {
        this.ProviderController = providerController;
        this.HarvesterController = harvesterController;

        //this.serviceProvider = serviceProvider;
        //this.HarvesterController = this.serviceProvider.GetService<IHarvesterController>();
        //this.ProviderController = this.serviceProvider.GetService<IProviderController>();
    }

    public IHarvesterController HarvesterController { get; private set; }

    public IProviderController ProviderController { get; private set; }

    public string ProcessCommand(IList<string> args)
    {
        ICommand command = this.GetCommand(args);

        var result = command.Execute();
        return result;
    }

    private ICommand GetCommand(IList<string> args)
    {
        string commandName = args[0];
        args = args.Skip(1).ToList();

        Assembly assembly = Assembly.GetCallingAssembly();
        Type commandType = assembly.GetTypes().FirstOrDefault(t => t.Name == commandName + "Command");

        if (commandType == null)
            throw new ArgumentException(String.Format(Constants.CommandNotFound, commandName));

        if (!typeof(ICommand).IsAssignableFrom(commandType))
            throw new InvalidOperationException(String.Format(Constants.NotACommand, commandName));

        ParameterInfo[] ctorParams = commandType.GetConstructors().First().GetParameters();
        object[] ctorArgs = new object[ctorParams.Length];
        ctorArgs[0] = args;

        if (ctorParams.Length == 3)
        {
            ctorArgs[1] = this.ProviderController;
            ctorArgs[2] = this.HarvesterController;
        }
        else
        {
            if (ctorParams[1].ParameterType == typeof(IProviderController))
                ctorArgs[1] = this.ProviderController;
            else if (ctorParams[1].ParameterType == typeof(IHarvesterController))
                ctorArgs[1] = this.HarvesterController;
        }

        //for (int i = 1; i < ctorArgs.Length; i++)
        //{
        //    Type paramType = ctorParams[i].ParameterType;
        //    object param = this.serviceProvider.GetService(paramType);
        //    ctorArgs[i] = param;
        //}

        ICommand command = (ICommand)Activator.CreateInstance(commandType, ctorArgs);
        return command;
    }
}