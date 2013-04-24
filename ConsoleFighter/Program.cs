using ConsoleFighter.Skills;
using System;
using System.Collections.Generic;

namespace ConsoleFighter
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        Hero Player1;
        Hero Player2;
        ConsoleManager ConsoleManager;
        HeroGenerator HeroGenerator;

        public Program()
        {
            HeroGenerator = new HeroGenerator();
            Player1 = HeroGenerator.GenerateHero();
            Player1.Controller = new Human(ConsoleManager);
            Player2 = HeroGenerator.GenerateHero();
            Player2.Controller = new Bot();
            ConsoleManager = new ConsoleManager(Player1, Player2);
            ConsoleManager.ShowStats();
            while (true)
            {
                Player1.Controller.GetNextAction(Player1, Player2).ExecuteSkill(Player1, Player2);
                ConsoleManager.ShowStats();
                if (CheckLife())
                {
                    break;
                }
                Player2.Controller.GetNextAction(Player2, Player1).ExecuteSkill(Player2, Player1);
                ConsoleManager.ShowStats();
                CheckLife();
            }
            while (true)
            {
                Console.Read();
            }
        }

        public bool CheckLife()
        {
            if (Player1.Health <= 0)
            {
                ConsoleManager.ShowWinner(Player2);
                return true;
            }
            if (Player2.Health <= 0)
            {
                ConsoleManager.ShowWinner(Player1);
                return true;
            }
            return false;
        }
    }
}
