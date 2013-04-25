namespace ConsoleFighter.Skills
{
    public interface Skill
    {
        void ExecuteSkill(Hero Attacker, Hero Defender);
        string GetName();
    }

    public class Attack : Skill
    {
        public void ExecuteSkill(Hero Attacker, Hero Defender)
        {
            Defender.Health -= Attacker.Attack - Defender.Attack_Defense;
            System.Console.WriteLine(Attacker.Name + " deals " + (Attacker.Attack - Defender.Attack_Defense) + " damage to " + Defender.Name);
        }


        public string GetName()
        {
            return "Attack";
        }
    }

    public class Wait : Skill
    {
        public void ExecuteSkill(Hero Attacker, Hero Defender)
        {
            // Nothing to do here, obviously.
            System.Console.WriteLine(Attacker.Name + " just stands there");
        }


        public string GetName()
        {
            return "Wait";
        }
    }

    public class Weaken : Skill
    {
        public void ExecuteSkill(Hero Attacker, Hero Defender)
        {
            if (Defender.Attack > 5)
            {
                Defender.Attack -= 5;
                System.Console.WriteLine(Attacker.Name + " decreases " + Defender.Name + " defense by 5");
            }
            else
            {
                System.Console.WriteLine(Defender.Name + "'s Defense can't be decreased any more");
            }
        }


        public string GetName()
        {
            return "Weaken";
        }
    }

    public class Fire : Skill
    {
        public void ExecuteSkill(Hero Attacker, Hero Defender)
        {
            Defender.Health -= 5 + Attacker.Magic - Defender.Magic;
            System.Console.WriteLine(Attacker.Name + " casts fire, dealing " + (Attacker.Attack - Defender.Attack_Defense) + " damage to " + Defender.Name);
        }


        public string GetName()
        {
            return "Fire";
        }
    }

    public class Shield : Skill
    {
        public void ExecuteSkill(Hero Attacker, Hero Defender)
        {
            Attacker.Attack_Defense += 5;
            Attacker.Magic_Defense += 5;
            System.Console.WriteLine(Attacker.Name + " increases his defense by 5");
        }


        public string GetName()
        {
            return "Shield";
        }
    }

    public class Sleep : Skill
    {
        public void ExecuteSkill(Hero Attacker, Hero Defender)
        {
            Attacker.Health += 10;
            System.Console.WriteLine(Attacker.Name + " starts to sleep, healing himself for 10 Health");
        }


        public string GetName()
        {
            return "Sleep";
        }
    }

    public class Soullink : Skill
    {
        public void ExecuteSkill(Hero Attacker, Hero Defender)
        {
            Attacker.Health += 5;
            Defender.Health -= 5 + Attacker.Magic - Defender.Magic_Defense;
            //! TODO
            System.Console.WriteLine("TODO");
        }


        public string GetName()
        {
            return "Sleep";
        }
    }
}
