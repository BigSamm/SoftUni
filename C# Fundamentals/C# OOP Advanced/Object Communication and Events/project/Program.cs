using System;

namespace Object_Communication_and_Events_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger combatLog = new CombatLogger();
            Logger eventLog = new EventLogger();

            combatLog.SetSuccessor(eventLog);

            IAttackGroup group = new Group();

            group.AddMember(new Warrior("Torsten", 10, combatLog));
            group.AddMember(new Warrior("Rolo", 15, combatLog));
            
            ITarget dragon = new Dragon("Transylvanian White", 100, 25, combatLog);

            IExecutor executor = new CommandExecutor();

            ICommand groupTarget = new GroupTargetCommand(group, dragon);
            ICommand groupAttack = new GroupAttackCommand(group);
        }
    }
}
