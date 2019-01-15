using System;
//using Microsoft.Extensions.DependencyInjection;

public class StartUp
{
    public static void Main(string[] args)
    {
        //IServiceProvider serviceProvider = ConfigureServices();

        IHarvesterFactory harvesterFactory = new HarvesterFactory();
        IEnergyRepository energyRepository = new EnergyRepository();

        IHarvesterController harvesterController = new HarvesterController(harvesterFactory, energyRepository);
        IProviderController providerController = new ProviderController(energyRepository);

        ICommandInterpreter commandInterpreter = new CommandInterpreter(providerController, harvesterController);

        IReader reader = new ConsoleReader();
        IWriter writer = new ConsoleWriter();
        Engine engine = new Engine(commandInterpreter, reader, writer);
        engine.Run();
    }

    //private static IServiceProvider ConfigureServices()
    //{
    //    IServiceCollection services = new ServiceCollection();

    //    services.AddSingleton<IHarvesterController, HarvesterController>();
    //    services.AddSingleton<IProviderController, ProviderController>();
    //    services.AddSingleton<IEnergyRepository, EnergyRepository>();
    //    services.AddSingleton<IHarvesterFactory, HarvesterFactory>();

    //    IServiceProvider serviceProvider = services.BuildServiceProvider();
    //    return serviceProvider;
    //}
}