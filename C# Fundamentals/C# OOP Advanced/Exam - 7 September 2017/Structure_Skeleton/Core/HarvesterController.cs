using System;
using System.Collections.Generic;

public class HarvesterController : IHarvesterController
{
    private List<IHarvester> harvesters;
    IEnergyRepository energyRepository;
    private IHarvesterFactory harvesterFactory;

    private string mode;

    public HarvesterController(IHarvesterFactory harvesterFactory, IEnergyRepository energyRepository)
    {
        this.harvesters = new List<IHarvester>();
        this.mode = "Full";

        this.harvesterFactory = harvesterFactory;
        this.energyRepository = energyRepository;
    }

    public double OreProduced { get; private set; }

    public IReadOnlyCollection<IEntity> Entities => this.harvesters.AsReadOnly();

    public string ChangeMode(string mode)
    {
        this.mode = mode;

        List<IHarvester> reminder = new List<IHarvester>();
        foreach (IHarvester harvester in this.harvesters)
        {
            try
            {
                harvester.Broke();
            }
            catch (Exception)
            {
                reminder.Add(harvester);
            }
        }
    
        foreach (var entity in reminder)
        {
            this.harvesters.Remove(entity);
        }

        return String.Format(Constants.ChangeMode, mode);
    }

    public string Produce()
    {
        double neededEnergy = 0;
        foreach (var harvester in this.harvesters)
        {
            if (this.mode == "Full")
                neededEnergy += harvester.EnergyRequirement;
            else if (this.mode == "Half")
                neededEnergy += harvester.EnergyRequirement * 50 / 100;
            else if (this.mode == "Energy")
                neededEnergy += harvester.EnergyRequirement * 20 / 100;
        }

        double minedOres = 0d;
        if (energyRepository.TakeEnergy(neededEnergy))
        {
            foreach (var harvester in this.harvesters)
            {
                minedOres += harvester.Produce();
            }
        }

        if (this.mode == "Energy")
            minedOres = minedOres * 20 / 100;
        else if (this.mode == "Half")
            minedOres = minedOres * 50 / 100;

        this.OreProduced += minedOres;

        return String.Format(Constants.OreOutputToday, minedOres);
    }

    public string Register(IList<string> args)
    {
        IHarvester harvester = this.harvesterFactory.GenerateHarvester(args);
        this.harvesters.Add(harvester);

        return String.Format(Constants.SuccessfullRegistration, harvester.GetType().Name);
    }
}