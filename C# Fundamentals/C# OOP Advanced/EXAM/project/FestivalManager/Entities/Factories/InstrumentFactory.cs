namespace FestivalManager.Entities.Factories
{
	using System;
	using System.Linq;
	using System.Reflection;
	using System.Runtime.InteropServices.WindowsRuntime;
	using Contracts;
	using Entities.Contracts;

	public class InstrumentFactory : IInstrumentFactory
	{
		public IInstrument CreateInstrument(string type)
		{
            Assembly assembly = Assembly.GetCallingAssembly();
            Type instrumentType = assembly.GetTypes().FirstOrDefault(t => t.Name == type);

            if (instrumentType == null)
                throw new ArgumentException("Invalid instrument type!");

            if (!typeof(IInstrument).IsAssignableFrom(instrumentType))
                throw new InvalidOperationException($"{type} is not an IInstrument");

            IInstrument instrument = (IInstrument)Activator.CreateInstance(instrumentType);
            return instrument;
		}
	}
}