using System;

namespace ConsoleFighter
{
    public class ConsoleManager
    {
        Hero Player1;
        Hero Player2;

        public ConsoleManager(Hero Player1, Hero Player2)
        {
            this.Player1 = Player1;
            this.Player2 = Player2;
        }

        public void ShowStats()
        {
            Console.Clear();
            Console.WriteLine(Player1.Name);
            Console.WriteLine("Health: " + Player1.Health);
            Console.WriteLine("Attack: " + Player1.Attack);
            Console.WriteLine("Attack Defense: " + Player1.Attack_Defense);
            Console.WriteLine("Magic: " + Player1.Magic);
            Console.WriteLine("Magic Defense: " + Player1.Magic_Defense);
            Console.WriteLine("---------------------");
            Console.WriteLine(Player2.Name);
            Console.WriteLine("Health: " + Player2.Health);
            Console.WriteLine("Attack: " + Player2.Attack);
            Console.WriteLine("Attack Defense: " + Player2.Attack_Defense);
            Console.WriteLine("Magic: " + Player2.Magic);
            Console.WriteLine("Magic Defense: " + Player2.Magic_Defense);
            Console.WriteLine("---------------------");
        }

        public void ShowWinner(Hero Winner)
        {
            ShowStats();
            Console.WriteLine(Winner.Name + " has won the Fight!");
        }
    }
}
