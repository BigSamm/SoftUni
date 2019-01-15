namespace SIS.Framework.Services
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using Contracts;

    public class DependencyContainer : IDependencyContainer
    {
        private readonly IDictionary<Type, Type> dependencyDictionary;

        public DependencyContainer()
        {
            this.dependencyDictionary = new Dictionary<Type, Type>();
        }

        private Type this[Type key]
            => this.dependencyDictionary.ContainsKey(key) ? this.dependencyDictionary[key] : null; 

        public T CreateInstance<T>()
        {
            return (T)this.CreateInstance(typeof(T));
        }

        public object CreateInstance(Type type)
        {
            Type instanceType = this[type] ?? type;

            if (instanceType.IsInterface || instanceType.IsAbstract)
                throw new InvalidOperationException($"Type {instanceType.FullName} cannot be instantiated.");

            ConstructorInfo constructor = instanceType
                .GetConstructors()
                .OrderByDescending(x => x.GetParameters().Length)
                .First();
            ParameterInfo[] constructorParameters = constructor.GetParameters();
            object[] constructorParameterObjects = new object[constructorParameters.Length];

            for (int i = 0; i < constructorParameters.Length; i++)
            {
                constructorParameterObjects[i] = this.CreateInstance(constructorParameters[i].ParameterType);
            }

            return constructor.Invoke(constructorParameterObjects);
        }

        public void RegisterDependency<TSoutce, TDestination>()
        {
            this.dependencyDictionary[typeof(TSoutce)] = typeof(TDestination);
        }
    }
}