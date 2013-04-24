using ConsoleFighter.Skills;
using System.Collections.Generic;

namespace ConsoleFighter
{
    public class Hero
    {
        public string Name;
        public int Health;
        public int Attack;
        public int Attack_Defense;
        public int Magic;
        public int Magic_Defense;
        public int Speed;
        public List<Skill> SkillSet;
        public Controller Controller;

        public Hero()
        {
            SkillSet = new List<Skill>();
        }
    }
}
