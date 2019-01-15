using System;

using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace FestivalManager.Entities.Factories
{
	using Contracts;
	using Entities.Contracts;
	using Sets;

	public class SetFactory : ISetFactory
	{
		public ISet CreateSet(string name, string type)
		{
            Assembly assembly = Assembly.GetCallingAssembly();
            Type setType = assembly.GetTypes().FirstOrDefault(t => t.Name == type);

            if (setType == null)
                throw new ArgumentException("Invalid set type!");

            if (!typeof(ISet).IsAssignableFrom(setType))
                throw new InvalidOperationException($"{type} is not an ISet");
            
            ISet instrument = (ISet)Activator.CreateInstance(setType, new object[] { name });
            return instrument;
		}
	}




}
