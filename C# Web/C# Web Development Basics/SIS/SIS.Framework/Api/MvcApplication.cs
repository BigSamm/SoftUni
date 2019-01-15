namespace SIS.Framework.Api
{
    using Contracts;
    using Services.Contracts;

    public class MvcApplication : IMvcApplication
    {
        public virtual void Configure()
        { }

        public virtual void ConfigureServices(IDependencyContainer dependencyContainer)
        { }
    }
}