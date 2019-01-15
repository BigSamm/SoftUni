using System;
using System.Collections.Generic;
using System.Text;

public class ShutdownCommand : Command
{
    private IProviderController providerController;
    private IHarvesterController harvesterController;

    public ShutdownCommand(List<string> args,
        IProviderController providerController, IHarvesterController harvesterController) 
        : base(args)
    {
        this.providerController = providerController;
        this.harvesterController = harvesterController;
    }

    public override string Execute()
    {
        var result = new StringBuilder();

        result.AppendLine(Constants.Shutdown);

        double totalEnergyProduced = this.providerController.TotalEnergyProduced;
        result.AppendLine(String.Format(Constants.TotalEnergyProduced, totalEnergyProduced));

        double totalMinedOre = this.harvesterController.OreProduced;
        result.AppendLine(String.Format(Constants.TotalMinedOre, totalMinedOre));

        return result.ToString().TrimEnd();
    }
}