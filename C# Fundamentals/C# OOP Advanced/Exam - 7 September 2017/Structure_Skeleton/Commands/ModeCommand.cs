using System.Collections.Generic;

public class ModeCommand : Command
{
    private IHarvesterController harvesterController;

    public ModeCommand(List<string> args, IHarvesterController harvesterController)
        : base(args)
    {
        this.harvesterController = harvesterController;
    }

    public override string Execute()
    {
        string mode = base.Arguments[0];
        string result = this.harvesterController.ChangeMode(mode);

        return result;
    }
}