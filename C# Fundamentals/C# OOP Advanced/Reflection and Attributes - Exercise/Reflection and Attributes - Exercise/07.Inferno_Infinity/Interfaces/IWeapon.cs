using System;
using System.Collections.Generic;
using System.Text;

public interface IWeapon
{
    string Name { get; }
    
    int MinDamage { get; }

    int MaxDamage { get; }

    RarityLevel RarityLevel { get; }

    IGem[] Sockets { get; }

    void RemoveGem(int socketIndex);

    void AddGem(IGem gem, int socketIndex);
}