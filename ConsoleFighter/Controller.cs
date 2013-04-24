using ConsoleFighter.Skills;
using System;

namespace ConsoleFighter
{
    public interface Controller
    {
        Skill GetNextAction(Hero Attacker, Hero Defenderr);
    }

    public class Human : Controller
    {
        ConsoleManager ConsoleManager;

        public Human(ConsoleManager ConsoleManager)
        {
            this.ConsoleManager = ConsoleManager;
        }

        public Skill GetNextAction(Hero Attacker, Hero Defender)
        {
            while (true)
            {
                Console.WriteLine("What do you want do do, " + Attacker.Name + "?");
                int Counter = 0;
                foreach (Skill Skill in Attacker.SkillSet)
                {
                    Console.WriteLine(Counter + ") " + Skill.GetName());
                    Counter++;
                }
                string Input = Console.ReadLine();
                int InputNumber = 0;
                try
                {
                    InputNumber = Convert.ToInt32(Input);
                }
                catch { }
                if (InputNumber >= 0 && InputNumber < Attacker.SkillSet.Count)
                {
                    return Attacker.SkillSet[InputNumber];
                }
            }
        }
    }

    public class Bot : Controller
    {
        Random Random = new Random();

        public Skill GetNextAction(Hero Attacker, Hero Defenderr)
        {
            return Attacker.SkillSet[Random.Next(Attacker.SkillSet.Count)];
        }
    }
}
