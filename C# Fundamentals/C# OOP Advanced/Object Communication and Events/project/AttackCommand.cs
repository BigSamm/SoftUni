using System;

public class AttackCommand : ICommand
{
    public AttackCommand(IAttacker attacker)
    {
        this.Attacker = attacker;
    }

    public IAttacker Attacker { get; private set; }

    public void Execute()
    {
        throw new NotImplementedException();
    }
}