namespace SIS.Framework.Services.Contracts
{
    using System;

    public interface IDependencyContainer
    {
        void RegisterDependency<TSoutce, TDestination>();

        T CreateInstance<T>();

        object CreateInstance(Type type); 
    }
}