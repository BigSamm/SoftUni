using System;

public class GroupTargetCommand : ICommand
{
    public GroupTargetCommand(IAttackGroup group, ITarget target)
    {
        this.Group = group;
        this.Target = target;
    }

    public IAttackGroup Group { get; private set; }

    public ITarget Target { get; private set; }

    public void Execute()
    {
        throw new NotImplementedException();
    }
}