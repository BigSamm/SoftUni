namespace Forum.App.Factories
{
	using Contracts;
    using System;
    using System.Linq;
    using System.Reflection;

    public class CommandFactory : ICommandFactory
	{
        private IServiceProvider serviceProvider;

        public CommandFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

		public ICommand CreateCommand(string commandName)
		{
            Assembly assembly = Assembly.GetExecutingAssembly();
            Type commandType = assembly.GetTypes().FirstOrDefault(t => t.Name == commandName + "Command");

            if (commandType == null)
                throw new InvalidOperationException("Command not found!");

            if (!typeof(ICommand).IsAssignableFrom(commandType))
                throw new ArgumentException($"{commandType.Name} is not a command!");

            ParameterInfo[] ctorParams = commandType.GetConstructors().First().GetParameters();
            object[] args = new object[ctorParams.Length];

            for (int index = 0; index < args.Length; index++)
            {
                args[index] = this.serviceProvider.GetService(ctorParams[index].ParameterType);
            }

            ICommand command = (ICommand)Activator.CreateInstance(commandType, args);
            return command;
		}
	}
}
