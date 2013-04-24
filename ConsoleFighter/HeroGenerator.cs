using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleFighter.Skills;

namespace ConsoleFighter
{
    class HeroGenerator
    {
        Random Random;

        public HeroGenerator()
        {
            Random = new Random();
        }

        public Hero GenerateHero()
        {
            Hero Hero = new Hero();
            switch (Random.Next(4))
            {
                case 0:
                    Hero.Name = "Mario";
                    Hero.Health = 75;
                    Hero.Attack = 20;
                    Hero.Attack_Defense = 5;
                    Hero.Magic = 20;
                    Hero.Magic_Defense = 5;
                    Hero.SkillSet.Add(new Attack());
                    Hero.SkillSet.Add(new Fire());
                    Hero.SkillSet.Add(new Wait());
                    break;
                case 1:
                    Hero.Name = "Kirby";
                    Hero.Health = 125;
                    Hero.Attack = 15;
                    Hero.Attack_Defense = 15;
                    Hero.Magic = 25;
                    Hero.Magic_Defense = 10;
                    Hero.SkillSet.Add(new Attack());
                    Hero.SkillSet.Add(new Weaken());
                    Hero.SkillSet.Add(new Wait());
                    break;
                case 2:
                    Hero.Name = "Samus";
                    Hero.Health = 100;
                    Hero.Attack = 15;
                    Hero.Attack_Defense = 15;
                    Hero.Magic = 10;
                    Hero.Magic_Defense = 15;
                    Hero.SkillSet.Add(new Attack());
                    Hero.SkillSet.Add(new Wait());
                    break;
                case 3:
                    Hero.Name = "Link";
                    Hero.Health = 100;
                    Hero.Attack = 25;
                    Hero.Attack_Defense = 10;
                    Hero.Magic = 5;
                    Hero.Magic_Defense = 15;
                    Hero.SkillSet.Add(new Attack());
                    Hero.SkillSet.Add(new Wait());
                    break;
                case 4:
                    Hero.Name = "Bowser";
                    Hero.Health = 175;
                    Hero.Attack = 15;
                    Hero.Attack_Defense = 10;
                    Hero.Magic = 0;
                    Hero.Magic_Defense = 0;
                    Hero.SkillSet.Add(new Attack());
                    Hero.SkillSet.Add(new Shield());
                    Hero.SkillSet.Add(new Wait());
                    break;
            }
            switch (Random.Next(4))
            {
                case 0:
                    Hero.Name += " the Mighty";
                    Hero.Attack += 5;
                    Hero.Health += 5;
                    break;
                case 1:
                    Hero.Name += " the Intelligent";
                    Hero.Magic += 10;
                    Hero.Magic_Defense += 10;
                    break;
                case 2:
                    Hero.Name += " the Giant";
                    Hero.Health += 20;
                    break;
                case 3:
                    Hero.Name += " the Berserker";
                    Hero.Attack += 15;
                    Hero.Health -= 10;
                    break;
                case 4:
                    Hero.Name += " the Defensive";
                    Hero.Attack_Defense += 10;
                    Hero.Magic_Defense += 10;
                    break;
            }
            return Hero;
        }
    }
}
