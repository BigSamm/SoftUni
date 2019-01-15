using System;

public class TargetCommand : ICommand
{
    public TargetCommand(IAttacker attacker, ITarget target)
    {
        this.Attacker = attacker;
        this.Target = target;
    }

    public IAttacker Attacker { get; private set; }

    public ITarget Target { get; private set; }

    public void Execute()
    {
        throw new NotImplementedException();
    }
}