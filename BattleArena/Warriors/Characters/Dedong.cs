using BattleArena.Abilities;
using BattleArena.Combat;
using BattleArena.Enums;
using System;
using System.Threading;
using static System.Net.Mime.MediaTypeNames;

namespace BattleArena.Warriors
{
    public class Dedong : Warrior, IDefender
    {
        public int Libag { get; set; }


        public Dedong(int health, int attackPower, int libag, TeamType teamType)
            : base("Dedong", health, attackPower, WarriorType.Tank, teamType)
        {
            Libag = libag;
            attackPower += libag;
        }
        public override void Attack(Warrior target)
        {
            var dmginfo = new DamageInfo(AttackPower, "Choco na gatas", HasCriticalChance, this);
            Console.WriteLine($"\t->{Name}: Aray ko wag akol! {target.Name}");

            Thread.Sleep(1000);
            Console.WriteLine($"\t->{target.Name}: wag kami!");

            Thread.Sleep(1000);
            if (target.IsAlive)
                Console.WriteLine($"\t->{target.Name}: {target.Name} BAInte! {target.Name}");
        }

        protected override void TakeDamage(DamageInfo damage)
        {
            var newActualDamage = damage.TotalAmountDamage - Libag;

            var blockChance = _random.Next(0, 100);
            var isBlocked = blockChance < 50;
            _damageTaken = damage;

            if (isBlocked) Block();
            else
            {

                var newDmgInfo = new DamageInfo(newActualDamage, damage.AttackType, damage.IsCritical, damage.From);
                base.TakeDamage(newDmgInfo);
            }
        }

        public void Block()
        {
            var blockMessage = $"Uyy Dodge! Blocked {_damageTaken.TotalAmountDamage} damage from{_damageTaken.From.Name}!";
        }


    }


}