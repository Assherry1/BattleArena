using BattleArena.Warriors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Chris = new Chris(10, 30, 3);
            var Dedong = new Dedong(200, 15, 10);

            Chris.DisplayStatus();
            Dedong.DisplayStatus();

            while (Chris.IsAlive && Dedong.IsAlive)
            {
                Console.WriteLine("\n\n=================================================");
                Chris.Attack(Dedong);
                Dedong.DisplayStatus();
                Console.WriteLine("-------------------------------------------------");
                Thread.Sleep(2000);
                Dedong.Attack(Chris);
                Chris.DisplayStatus();
                Thread.Sleep(2000);
            }

            Console.ReadKey();
        }
    }
}