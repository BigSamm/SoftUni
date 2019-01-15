using System.Collections.Generic;

public class RepairCommand : Command
{
    private IProviderController providerController;

    public RepairCommand(List<string> args, IProviderController providerController) 
        : base(args)
    {
        this.providerController = providerController;
    }

    public override string Execute()
    {
        double val = double.Parse(base.Arguments[0]);
        string result = providerController.Repair(val);

        return result;
    }
}