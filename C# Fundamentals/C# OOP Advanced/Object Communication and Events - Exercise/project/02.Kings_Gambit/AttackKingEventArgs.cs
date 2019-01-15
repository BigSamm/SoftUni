using System;
using System.Collections.Generic;

public class AttackKingEventArgs : EventArgs
{
    public AttackKingEventArgs(string kingName, List<IUnit> aliveUnits)
    {
        this.KingName = kingName;
        this.AliveUnits = aliveUnits;
    }

    public string KingName { get; private set; }

    public List<IUnit> AliveUnits { get; private set; }
}