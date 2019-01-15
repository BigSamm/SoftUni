using System;
using System.Collections.Generic;
using System.Linq;

public class King : IKing
{
    public event AttackKingEventHandler GetAttackedEvent;

    public King(string name)
    {
        this.Name = name;
        this.AllUnits = new List<IUnit>();
    }

    public string Name { get; private set; }

    public List<IUnit> AllUnits { get; private set; }

    public List<IUnit> AliveUnits => this.AllUnits.Where(u => u.IsAlive == true).ToList();

    public void AddUnit(IUnit unit)
    {
        this.AllUnits.Add(unit);
    }

    public void RespondAttack()
    {
        if (this.GetAttackedEvent != null)
        {
            GetAttackedEvent.Invoke(this, new AttackKingEventArgs(this.Name, this.AliveUnits));
        }
    }
}