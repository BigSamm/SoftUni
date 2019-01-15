using System;

public class GroupAttackCommand : ICommand
{
    public GroupAttackCommand(IAttackGroup group)
    {
        this.Group = group;
    }

    public IAttackGroup Group { get; private set; }

    public void Execute()
    {
        throw new NotImplementedException();
    }
}