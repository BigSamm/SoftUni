public class Sword : Weapon
{
    private const int MIN_DAMAGE = 4;
    private const int MAX_DAMAGE = 6;
    private const int SOCKETS_COUNT = 3;

    public Sword(string name, RarityLevel rarityLevel)
        : base(name, MIN_DAMAGE, MAX_DAMAGE, SOCKETS_COUNT, rarityLevel)
    {
    }
}