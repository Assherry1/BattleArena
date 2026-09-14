using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena.Warriors.Characters
{
    public class Kuyukot : Warrior
    {
        public Kuyukot(int health, int attackPower)
            : base("Kuyukot", health, attackPower, WarriorType.Magery)
        {

        }

        public override void Attack(Warrior target)
        {
            throw new NotImplementedException();
        }
    }
}