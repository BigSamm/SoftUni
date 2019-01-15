using System.Collections.Generic;

public interface IKing : IName, IAttackable
{
    List<IUnit> AllUnits { get; }

    void AddUnit(IUnit unit);
}