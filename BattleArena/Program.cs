using BattleArena.Warriors;
using System;

namespace BattleArena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int round = 1;
            Warrior Raymond = new Warrior("Raymond", 100, 30, "Dinuraan");
            Warrior Kirk = new Warrior("Kirk", 200, 15, "Dinaganan");
            Warrior Crisy = new Warrior("Crisy", 150, 30, "Fire Ball");

            Raymond.DisplayStats();
            Kirk.DisplayStats();
            Crisy.DisplayStats();

            while (Raymond.IsAlive && Kirk.IsAlive && Crisy.IsAlive)
            {
                Console.WriteLine($"------Round {round}------");
                Raymond.Attack(Kirk);
                Kirk.Attack(Crisy);
                Crisy.Attack(Raymond);
                Console.WriteLine("----------------");
                round++;
            }

            Console.ReadKey();
        }
    }
}