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
        public int AsimDamage { get; private set; }
        public Asim(int health, int attackPower, int asimDamage)
            : base("Asim", health, attackPower, WarriorType.Fighter)
        {
            AsimDamage = asimDamage;
            attackPower += AsimDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Kulatahin si kenneth", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: kenneth moby {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: BAI kenneth!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: para kay Kenneth  {target.Name}");
        }
    }

}