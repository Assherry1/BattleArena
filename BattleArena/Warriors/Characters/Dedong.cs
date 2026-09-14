using System;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena.Warriors
{
    public class Dedong : Warrior
    {
        public int Shield { get; private set; }
        public Dedong(int health, int attackPower, int shield)
            : base("Dedong", health, attackPower, WarriorType.Tank)
        {
            Shield = shield;
        }

        public override void Attack(Warrior target)
        {

            var dmginfo = new DamageInfo(AttackPower, "Choco na batok", _hasCriticalChance);
            TakeDamage(dmginfo);



            Console.WriteLine($"\t-> {Name}: Okay! {target.Name}!");

            Thread.Sleep(1000);
            Console.WriteLine($"\t-> {target.Name}: parang thunder sa bilis!");


            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t-> {target.Name}: Self love bading {target.Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Shield;
            var newDmginfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical);
            base.TakeDamage(damage);
        }

    }
}