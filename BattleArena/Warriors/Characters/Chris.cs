using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;

namespace BattleArena.Warriors
{
    public class Chris : Warrior
    {
        public int ClickDamage { get; set; }

        public Chris(int health, int attackPower)
            : base("Chris", health, attackPower, WarriorType.Marksman, TeamType.A)
        {
            attackPower += ClickDamage;
        }


        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Mabisa", HasCriticalChance, this);
            TakeDamage(dmginfo);

            Thread.Sleep(1000);
            Console.WriteLine($"\t->{Name}: Tagalog vs Bisaya {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->{target.Name}: Bang");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} yoko na! {target.Name}");



        }


    }
}