namespace MappingObjects.App
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.DependencyInjection;
    using System;

    using Core;
    using Core.Contracts;
    using Core.Controllers;
    using Data;
    using Services;
    using Services.Contracts;

    public class StartUp
    {
        static void Main()
        {
            IServiceProvider service = ConfigureService();

            IRunable engine = new Engine(service);
            engine.Run();
        }

        private static IServiceProvider ConfigureService()
        {
            var serviceCollection = new ServiceCollection();

            serviceCollection.AddDbContext<MappingObjectsDbContext>(opts => opts.UseSqlServer(Configurations.ConnectionString));
            serviceCollection.AddAutoMapper(conf => conf.AddProfile<MappingObjectsProfile>());

            serviceCollection.AddTransient<IDbInitializerService, DbInitializerService>();
            serviceCollection.AddTransient<ICommandInterpreter, CommandInterpreter>();
            serviceCollection.AddTransient<IEmployeeController, EmployeeController>();
            serviceCollection.AddTransient<IManagerController, ManagerController>();

            IServiceProvider serviceProvider = serviceCollection.BuildServiceProvider();
            return serviceProvider;
        }
    }
}
