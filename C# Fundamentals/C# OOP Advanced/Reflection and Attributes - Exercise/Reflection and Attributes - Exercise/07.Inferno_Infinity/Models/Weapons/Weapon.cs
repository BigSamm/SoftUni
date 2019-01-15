using System;

public abstract class Weapon : IWeapon
{
    private int initialMinDamage;
    private int initialMaxDamage;

    protected Weapon(string name, int minDamage, int maxDamage, int socketsCount, RarityLevel rarityLevel)
    {
        this.Name = name;
        this.initialMinDamage = minDamage;
        this.initialMaxDamage = maxDamage;
        this.Sockets = new IGem[socketsCount];
        this.RarityLevel = rarityLevel;
        this.Strength = 0;
        this.Agility = 0;
        this.Vitality = 0;
    }

    public string Name { get; private set; }

    public int MinDamage => this.CalculateMinDamage();

    public int MaxDamage => this.CalculateMaxDamage();

    public RarityLevel RarityLevel { get; private set; }

    public IGem[] Sockets { get; private set; }

    public int Strength { get; private set; }

    public int Agility { get; private set; }

    public int Vitality { get; private set; }

    private int CalculateMinDamage()
    {
        var minDamage = this.initialMinDamage * (int)this.RarityLevel;

        minDamage += this.Strength * 2;
        minDamage += this.Agility;

        return minDamage;
    }

    private int CalculateMaxDamage()
    {
        var maxDamage = this.initialMaxDamage * (int)this.RarityLevel;

        maxDamage += this.Strength * 3;
        maxDamage += this.Agility * 4;

        return maxDamage;
    }
    
    public void RemoveGem(int socketIndex)
    {
        var removedGem = this.Sockets[socketIndex];
        this.Sockets[socketIndex] = null;

        this.Strength -= removedGem.StrengthBonus + (int)removedGem.ClarityLevel;
        this.Agility -= removedGem.AgilityBonus + (int)removedGem.ClarityLevel;
        this.Vitality -= removedGem.VitalityBonus + (int)removedGem.ClarityLevel;
    }

    public void AddGem(IGem gem, int socketIndex)
    {
        if (this.Sockets[socketIndex] != null)
            this.RemoveGem(socketIndex);

        this.Sockets[socketIndex] = gem;
        
        this.Strength += gem.StrengthBonus + (int)gem.ClarityLevel;
        this.Agility += gem.AgilityBonus + (int)gem.ClarityLevel;
        this.Vitality += gem.VitalityBonus + (int)gem.ClarityLevel;
    }

    public override string ToString()
    {
        var result = $"{this.Name}: {this.MinDamage}-{this.MaxDamage} Damage, " +
                     $"+{this.Strength} Strength, +{this.Agility} Agility, +{this.Vitality} Vitality";
        return result;
    }
}