using SIS.Framework.Api;
using SIS.Framework.Services;
using Torshia.App.Services;
using Torshia.App.Services.Contracts;

namespace Torshia.App
{
    public class StartUp : IMvcApplication
    {
        public void Configure()
        { }

        public void ConfigureServices(IDependencyContainer dependencyContainer)
        {
            dependencyContainer.RegisterDependency<IUsersService, UsersService>();
            dependencyContainer.RegisterDependency<ITasksService, TasksService>();
            dependencyContainer.RegisterDependency<IReportsService, ReportsService>();
        }
    }
}