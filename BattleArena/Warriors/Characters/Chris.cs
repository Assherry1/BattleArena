using System;
using System.Threading;
using System.Xml.Linq;

namespace BattleArena.Warriors
{
    public class Chris : Warrior
    {
        public int ClickDamage { get; private set; }
        public Chris(int health, int attackPower, int arrowDamage)
            : base("Chris", health, attackPower, WarriorType.Marksman)
        {
            ClickDamage = arrowDamage;
            attackPower += ClickDamage;
        }

        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Click", HasCriticalChance);
            TakeDamage(dmginfo);

            Console.WriteLine($"->{Name}: Click kita bebe {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"->{target.Name}: Yamot!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"->{target.Name}: eclipse {target.Name}");
        }
    }

}