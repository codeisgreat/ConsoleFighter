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
                #region Player1
                foreach (Skill Skill in Player1.SkillSet)
                {
                    Skill.RoundPassed(Player1, Player2);
                }
                Player1.Controller.GetNextAction(Player1, Player2).ExecuteSkill(Player1, Player2);
                Console.ReadKey(true);
                ConsoleManager.ShowStats();
                if (CheckLife())
                {
                    break;
                }
                #endregion

                #region Player2
                foreach (Skill Skill in Player2.SkillSet)
                {
                    Skill.RoundPassed(Player2, Player1);
                }
                Player2.Controller.GetNextAction(Player2, Player1).ExecuteSkill(Player2, Player1);
                Console.ReadKey(true);
                ConsoleManager.ShowStats();
                if (CheckLife())
                {
                    break;
                }
                #endregion
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
