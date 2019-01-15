using System.Collections.Generic;

public abstract class Command : ICommand
{
    protected Command(List<string> args)
    {
        this.Arguments = args;
    }

    public IList<string> Arguments { get; }

    public abstract string Execute();
}