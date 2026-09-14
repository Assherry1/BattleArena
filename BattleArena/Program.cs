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
            int round = 1;
            var Chris = new Chris(100, 30);
            var Dedong = new Dedong(200, 15, 10, Enums.TeamType.A);
            var Asim = new Asim(150, 30, 15);

            Asim.DisplayStatus();
            Dedong.DisplayStatus();
            Asim.DisplayStatus();

            while (Asim.IsAlive && Dedong.IsAlive && Chris.IsAlive)
            {
                Console.WriteLine("\n\n==========================================");
                Asim.Attack(Dedong);
                Dedong.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                Thread.Sleep(2000);
                Chris.Attack(Asim);
                Asim.DisplayStatus();
                Console.WriteLine("----------------------------------------------");
                Thread.Sleep(2000);
                Dedong.Attack(Chris);
                Chris.DisplayStatus();
                round++;
            }

            Console.ReadKey();
        }
    }
}