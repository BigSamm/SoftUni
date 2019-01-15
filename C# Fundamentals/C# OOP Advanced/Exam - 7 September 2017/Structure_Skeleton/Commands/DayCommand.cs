using System;
using System.Collections.Generic;
using System.Text;

public class DayCommand : Command
{
    private IProviderController providerController;
    private IHarvesterController harvesterController;

    public DayCommand(List<string> args,
        IProviderController providerController, IHarvesterController harvesterController) 
        : base(args)
    {
        this.providerController = providerController;
        this.harvesterController = harvesterController;
    }

    public override string Execute()
    {
        string providersResult = this.providerController.Produce();
        string harvesterResult = this.harvesterController.Produce();

        return providersResult + Environment.NewLine + harvesterResult;
    }
}