using System;
using System.Collections.Generic;
using System.Linq;

public class InspectCommand : Command
{
    private IProviderController providerController;
    private IHarvesterController harvesterController;

    public InspectCommand(List<string> args,
        IProviderController providerController, IHarvesterController harvesterController) 
        : base(args)
    {
        this.providerController = providerController;
        this.harvesterController = harvesterController;
    }

    public override string Execute()
    {
        int id = int.Parse(base.Arguments[0]);
        IEntity entity;

        entity = this.providerController.Entities.FirstOrDefault(e => e.ID == id);

        if (entity == null)
            entity = this.harvesterController.Entities.FirstOrDefault(e => e.ID == id);

        if (entity == null)
            return String.Format(Constants.EntityNotFound, id);

        return entity.GetType().Name + Environment.NewLine + String.Format(Constants.EntityDurability, entity.Durability);
    }
}