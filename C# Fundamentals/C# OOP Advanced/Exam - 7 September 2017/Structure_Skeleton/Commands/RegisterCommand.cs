using System.Collections.Generic;
using System.Linq;

public class RegisterCommand : Command
{
    private IProviderController providerController;
    private IHarvesterController harvesterController;

    public RegisterCommand(List<string> args, 
        IProviderController providerController, IHarvesterController harvesterController) 
        : base(args)
    {
        this.providerController = providerController;
        this.harvesterController = harvesterController;
    }

    public override string Execute()
    {
        string result = null;

        string type = base.Arguments[0];
        if (type == "Provider")
        {
            result = this.providerController.Register(base.Arguments.Skip(1).ToList());
        }
        else if (type == "Harvester")
        {
            result = this.harvesterController.Register(base.Arguments.Skip(1).ToList());
        }

        return result;
    }
}