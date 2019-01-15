using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class DraftManager
{
    private string mode;
    private double totalStoredEnergy;
    private double totalMinedOre;
    private List<Harvester> harvesters;
    private List<Provider> providers;
    private ProviderFactory providerFactory;
    private HarvesterFactory harvesterFactory;

    public DraftManager()
    {
        this.mode = "Full";
        this.totalStoredEnergy = 0;
        this.totalMinedOre = 0;
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.providerFactory = new ProviderFactory();
        this.harvesterFactory = new HarvesterFactory();
    }

    public string RegisterHarvester(List<string> arguments)
    {
        Harvester harvester;
        try
        {
            harvester = this.harvesterFactory.CreateHarvester(arguments);
            this.harvesters.Add(harvester);
            var result = $"Successfully registered {harvester.Type} Harvester - {harvester.Id}";
            return result;
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
    }

    public string RegisterProvider(List<string> arguments)
    {
        Provider provider;
        try
        {
            provider = this.providerFactory.CreateProvider(arguments);
            this.providers.Add(provider);
            var result = $"Successfully registered {provider.Type} Provider - {provider.Id}";
            return result;
        }
        catch (ArgumentException ex)
        {
            return ex.Message;
        }
    }

    public string Day()
    {
        var dayEnergyProvided = this.providers.Sum(p => p.EnergyOutput);
        this.totalStoredEnergy += dayEnergyProvided;

        double dayEnergyRequired, dayMinedOre;
        if (this.mode == "Full")
        {
            dayEnergyRequired = harvesters.Sum(h => h.EnergyRequirement);
            dayMinedOre = harvesters.Sum(h => h.ОreOutput);
        }
        else if (this.mode == "Half")
        {
            dayEnergyRequired = harvesters.Sum(h => h.EnergyRequirement) * .6;
            dayMinedOre = harvesters.Sum(h => h.ОreOutput) * .5;
        }
        else
        {
            dayEnergyRequired = 0;
            dayMinedOre = 0;
        }

        if (this.totalStoredEnergy >= dayEnergyRequired)
        {
            this.totalMinedOre += dayMinedOre;
            this.totalStoredEnergy -= dayEnergyRequired;
        }
        else
        {
            dayMinedOre = 0;
        }

        var result = "A day has passed." + Environment.NewLine +
                     $"Energy Provided: {dayEnergyProvided}" + Environment.NewLine +
                     $"Plumbus Ore Mined: {dayMinedOre}";
        return result;
    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];

        var result = $"Successfully changed working mode to {this.mode} Mode";
        return result;
    }

    public string Check(List<string> arguments)
    {
        var id = arguments[0];

        Unit unit = (Unit)this.harvesters.FirstOrDefault(h => h.Id == id) ?? this.providers.FirstOrDefault(p => p.Id == id);

        if (unit != null)
            return unit.ToString();
        else
            return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        var result = "System Shutdown" + Environment.NewLine +
                     $"Total Energy Stored: {this.totalStoredEnergy}" + Environment.NewLine +
                     $"Total Mined Plumbus Ore: {this.totalMinedOre}";
        return result;
    }
}