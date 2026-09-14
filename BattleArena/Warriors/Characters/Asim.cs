using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{

    public class Asim : Warrior
    {
        public int AnghitDamage { get; private set; }
        public Asim(int health, int attackPower, int anghitDamage)
            : base("Asim", health, attackPower, WarriorType.Fighter, TeamType.A)
        {
            AnghitDamage = anghitDamage;
            attackPower += anghitDamage;
        }

        public Asim(string name, int health, int attackPower)
            : base(name, health, attackPower, WarriorType.Fighter, TeamType.A)
        {
            AnghitDamage = AnghitDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Bakbak" , HasCriticalChance, this);
            TakeDamage(dmginfo);

            Console.WriteLine($"\t->{Name}: rasenggan {target.Name}");
            Thread.Sleep(1000);

            Console.WriteLine($"\t->{target.Name}: palo!");
            Thread.Sleep(1000);

            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} Earthings! {target.Name}");

        }


    }
}