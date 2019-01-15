namespace MappingObjects.App.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Contracts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private readonly IServiceProvider serviceProvider;

        public CommandInterpreter(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public string Read(string[] input)
        {
            string commandName = input[0] + "Command";
            string[] args = input.Skip(1).ToArray();

            Type type = Assembly.GetCallingAssembly().GetTypes().FirstOrDefault(x => x.Name == commandName);

            if (type == null)
                throw new ArgumentException("Invalid command!");

            ConstructorInfo ctor = type.GetConstructors().First();
            IEnumerable<Type> ctorParams = ctor.GetParameters().Select(c => c.ParameterType);

            object[] service = ctorParams.Select(this.serviceProvider.GetService).ToArray();

            IExecutable command = (IExecutable)ctor.Invoke(service);

            string result = command.Execute(args);
            return result;
        }
    }
}
