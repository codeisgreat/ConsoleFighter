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
}
