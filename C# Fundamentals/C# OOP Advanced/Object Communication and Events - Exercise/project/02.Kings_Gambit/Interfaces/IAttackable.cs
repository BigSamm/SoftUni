public delegate void AttackKingEventHandler(object sender, AttackKingEventArgs args);

public interface IAttackable
{
    event AttackKingEventHandler GetAttackedEvent;

    void RespondAttack();
}