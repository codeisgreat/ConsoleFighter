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
        }


        public string GetName()
        {
            return "Sleep";
        }
    }
}
